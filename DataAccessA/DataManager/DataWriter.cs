using DataAccessA.Classes;
using DataAccessA.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessA.DataManager
{
   public class DataWriter
    {
        static UvlotAEntities uvDb = new UvlotAEntities();


        public string TestRecord()
        {
            try
            {
                return "";
            }
            catch (Exception ex)
            {
                WebLog.Log(ex.Message.ToString());
                return null;
            }
        }
        public static int SaveBVNDetails(BVNC bvnc)
        {
            int i = 0;
            try
            {

                BanksManager bObj = new BanksManager
                {
                    BankName = bvnc.EnrollmentBank,
                    ContactAddress = bvnc.address,
                    DateOfBirth = bvnc.Dateofbirth,
                    EnrollmentBranch = bvnc.EnrollmentBranch,
                    Firstname = bvnc.FirstNAme,
                    Gender = bvnc.gender,
                    IsVisible = 1,
                    Lastname = bvnc.LastName,
                    Marital_Status = bvnc.marital_status,
                    Nationlaity = bvnc.Nationality,
                    Othernames = bvnc.MiddleName,
                    ValueDate = MyUtility.getCurrentLocalDateTime().ToString("yyyy/MM/dd"),
                    VerifiedStatus = bvnc.respCode == "00" ? 1 : 0,
                    ServiceResponse = bvnc.respDescription
                };
                uvDb.BanksManagers.Add(bObj);
                uvDb.SaveChanges();
            }
            catch (Exception ex)
            {
                WebLog.Log(ex.Message);
            }
            return i;
        }
        public int InsertUser(User user)
        {
           
            try
            {
                uvDb.Users.Add(user);
                uvDb.SaveChanges();
                return user.ID;

            }

            catch (Exception ex)
            {
                WebLog.Log(ex.Message.ToString());
                return ex.Message.Count();

            }

        }


        public int SaveApplication(NyscLoanApplication NyscLA)
        {
            try
            {

                uvDb.NyscLoanApplications.Add(NyscLA);
                uvDb.SaveChanges();
                return NyscLA.ID;

            }
            catch (Exception ex)
            {
                WebLog.Log(ex.Message);
                return 0;
            }

        }
        public int insertRemita(PatnerTransactLog PL)
        {

            try
            {
                uvDb.PatnerTransactLogs.Add(PL);
                uvDb.SaveChanges();
                return PL.ID;

            }

            catch (Exception ex)
            {
                WebLog.Log(ex.Message.ToString());
                return ex.Message.Count();

            }

        }
        
        public int insertLoanApproval(NYSCLoanApproval La)
        {

            try
            {
                uvDb.NYSCLoanApprovals.Add(La);
                uvDb.SaveChanges();
                return La.ID;

            }

            catch (Exception ex)
            {
                WebLog.Log(ex.Message.ToString());
                return ex.Message.Count();

            }

        }
        
        public static LoanApplication CreateLoanApplication(LoanApplication instObj)
        {
            try
            {
                // uvDb= new UvlotEntities();
                uvDb.LoanApplications.Add(instObj);
                uvDb.SaveChanges();
            }
            catch (Exception ex)
            {
                WebLog.Log(ex.Message);
            }
            return instObj;
        }
        
              public  int InsertUserRoles(UserRole userrole)
        {
            try
            {

                uvDb.UserRoles.Add(userrole);
                uvDb.SaveChanges();
                return userrole.ID;

            }
            catch (Exception ex)
            {
                WebLog.Log(ex.Message);
                return 0;
            }

        }

       
             public int CreateReferalCode(User user)
            {
            try
            {

                var valu = (uvDb.Users.Find(user.EmailAddress));

                if(valu != null)
                {
                    valu.MyReferralCode = user.MyReferralCode;
                    uvDb.SaveChanges();
                    return valu.ID;
                }
                return valu.ID;
            }
            catch (Exception ex)
            {
                WebLog.Log(ex.Message);
                return 0;
            }

        }

        public int UpdateLedger(string IDS, LoanLedger LoanLedger)
        {
            try
            {
                int ID = Convert.ToInt32(IDS);
                LoanLedger.ID = ID;
                var resp = uvDb.LoanLedgers.Find(LoanLedger.ID);

                if (resp != null)
                {
                    // resp.Credit = resp.Debit;
                    resp.Credit = LoanLedger.Credit;
                    resp.PaymentFlag_FK = LoanLedger.PaymentFlag_FK;
                    uvDb.SaveChanges();
                }
                return resp.ID;
            }
            catch (Exception ex)
            {
                WebLog.Log(ex.Message.ToString());
                return 0;
            }
        }



        public NYSCLoanLedger InsertLedgerTransact(string IDS, NYSCLoanLedger LoanLedger, Repayment Lt, float Ampd)
        {
            try
            {
                int ID = Convert.ToInt32(IDS);
                LoanLedger.ID = ID;
                var resp = uvDb.NYSCLoanLedgers.Find(LoanLedger.ID);
                if (resp != null)
                {
                    // Lt.colss = resp.ID;
                    // Lt.cols = instFk;
                    if (Ampd == 0)
                    {
                        Lt.Amount = resp.Credit;
                    }
                    else
                    {
                        Lt.Amount = Ampd;
                    }
                   
                    Lt.Created = MyUtility.getCurrentLocalDateTime();
                    Lt.Reference = resp.ReferenceNumber;
                    Lt.LedgerFlag = resp.ID;
                 
                    
                    uvDb.Repayments.Add(Lt);

                    uvDb.SaveChanges();
                }

                return resp;
            }
            catch (Exception ex)
            {
                WebLog.Log(ex.Message.ToString());
                return null;
            }
        }



        public int UpdateLedger(string IDS, NYSCLoanLedger LoanLedger)
        {
            try
            {
                int ID = Convert.ToInt32(IDS);
                // LoanLedger.ID = ID;
                // var resp = uvDb.NYSCLoanLedgers.Find(LoanLedger.ID);

                var resp = uvDb.NYSCLoanLedgers.Find(ID);

                if (resp != null)
                {
                    // resp.Credit = resp.Debit;
                    resp.Debit = LoanLedger.Credit;
                    resp.PaymentFlag = LoanLedger.PaymentFlag;
                    uvDb.SaveChanges();
                }
                return resp.ID;
            }
            catch (Exception ex)
            {
                WebLog.Log(ex.Message.ToString());
                return 0;
            }
        }

        //public NYSCLoanLedger InsertLedgerTransact(string IDS, NYSCLoanLedger LoanLedger, Repayment Lt, float Ampd, int instFk)
        //{
        //    try
        //    {
        //        int ID = Convert.ToInt32(IDS);
        //        LoanLedger.ID = ID;
        //        var resp = uvDb.NYSCLoanLedgers.Find(LoanLedger.ID);
        //        if (resp != null)
        //        {
        //            Lt.ID = resp.ID;
        //            Lt.ID = instFk;
        //            if (Ampd == 0)
        //            {
        //                Lt.Amount = resp.Debit;
        //            }
        //            else
        //            {
        //                Lt.Amount = Ampd;
        //            }

        //            //Lt. = resp.TranxDate;
        //            //Lt.TrnDate = MyUtility.getCurrentLocalDateTime();
        //            //Lt.ReferenceNumber = resp.RefNumber;
        //            //Lt.ValueDate = MyUtility.getCurrentLocalDateTime().Date.ToString();
        //            //Lt.ValueTime = MyUtility.getCurrentLocalDateTime().TimeOfDay.ToString();
        //            uvDb.Repayment.Add(Lt);
        //            uvDb.SaveChanges();
        //        }

        //        return resp;
        //    }
        //    catch (Exception ex)
        //    {
        //        WebLog.Log(ex.Message.ToString());
        //        return null;
        //    }
        //}


        public static int  CreateNYSCLoanApplication(NyscLoanApplication NyscLA)
        {
            try
            {
               
                uvDb.NyscLoanApplications.Add(NyscLA);
                uvDb.SaveChanges();
                return NyscLA.ID;
              
            }
            catch (Exception ex)
            {
                WebLog.Log(ex.Message);
                return 0;
            }
          
        }
        
    }
}
