﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessA.Classes
{
    public class AppLoans
        {
        public int ID { get; set; }
        public string AccountName { get; set; }
            public string LoanRefNumber { get; set; }
            public string LoanProduct { get; set; }
            public string Title { get; set; }
            public string Surname { get; set; }
            public string Firstname { get; set; }
            public string Othernames { get; set; }
            public string Gender { get; set; }

        public Nullable<double> CreditLimit { get; set; }
        public string MaritalStatus { get; set; }
            public string MeansOfIdentifications { get; set; }
            public string IdentficationNumber { get; set; }

            public string DateOfBirth { get; set; }

        public DateTime Enddate { get; set; }

        public DateTime Startdate { get; set; }


        public string PhoneNumber { get; set; }

            public string EmailAddress { get; set; }

            public string ContactAddress { get; set; }

            public string Landmark { get; set; }

            public string ClosestBusStop { get; set; }

            public string NigerianStates { get; set; }

            public string LGAs { get; set; }

            public string Organization { get; set; }

            public string ApplicantID { get; set; }

            public string NOK_FullName { get; set; }

            public string NOK_Relationship { get; set; }

            public string NOK_PhoneNumber { get; set; }
            public string NOK_EmailAddress { get; set; }
            public string NOK_HomeAddress { get; set; }
            public Double LoanAmount { get; set; }
            public int LoanTenure { get; set; }
            public Boolean ExistingLoan { get; set; }
            public Double ExistingLoan_OutstandingAmount { get; set; }
            public int ExistingLoan_NoOfMonthsLeft { get; set; }
        public string EMG_FullName { get; set; }

        public string EMG_HomeAddress { get; set; }
        public string EMG_PhoneNumber { get; set; }
        public string EMG_EmailAddress { get; set; }
        public string EMG_Relationship { get; set; }
        public string PermanentAddress { get; set; }
        public string TemporaryAddress { get; set; }
      
        public int StateofResidence_FK { get; set; }
        public string ApplicationStatus { get; set; }
        public string ConvertedAmount { get; set; }

        public int TempStateofResidence_FK { get; set; }
        public int NyscStateofResidence_FK { get; set; }
        public string TempLandmark { get; set; }
        public string TempClosestBusStop { get; set; }
        public int LGA_FK { get; set; }
        public int TempLGA_FK { get; set; }
        public int NyscLGA_FK { get; set; }
        public string StateCode { get; set; }
        public string Employer { get; set; }
        public string PassOutMonth { get; set; }
        public string CDSDay { get; set; }
        public string CDSGroup { get; set; }
        public string BankCode { get; set; }
            public string AccountNumber { get; set; }
            public string ValueDate { get; set; }
            public string BVN { get; set; }
        public string SalaryAmount { get; set; }
        public string MatriculationNumber { get; set; }
            public string Institutions { get; set; }
           public string Faculty { get; set; }
           public string Department { get; set; }
        public string Institution { get; set; }
    }

    public class Top50Referral
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public double Disbursedloan { get; set; }
        public string ValueDates { get; set; }
        public string RepaymentAmount { get; set; }

        public int ActiveLoans { get; set; }
        public int DefaultLoans { get; set; }

        public double CommisionEarned { get; set; }
        public double CommisionPaid { get; set; }

        public double walletBalance { get; set; }

     
    }

        public class AppLoanss
    {
        public int ID { get; set; }
        public string LoanRefNumber { get; set; }
        public int Title_FK { get; set; }
        public int NYSCApplicationStatus_FK { get; set; }
        
             public DateTime ApplicationApprove { get; set; }
        public DateTime APplicationDate { get; set; }
        public string ValueDates { get; set; }
        public string Title { get; set; }
        public string Surname { get; set; }
        public string comment { get; set; }
        public string Firstname { get; set; }
       
       public string EMG_EmailAddress2 { get; set; }
        public string EMG_FullName2 { get; set; }
        public string EMG_HomeAddress2 { get; set; }
        public string EMG_PhoneNumber2 { get; set; }
        public string EMG_Relationship2 { get; set; }
        public string FacebookName { get; set; }
        public string InstagramHandle { get; set; }
        public string TwitterHandle { get; set; }
        public string ReferalCode { get; set; }
        public string MaritalStatus { get; set; }
        public string Othernames { get; set; }
        public string AppStat { get; set; }
        public int Gender_FK { get; set; }
        public int MaritalStatus_FK { get; set; }
        public int MeansOfID_FK { get; set; }
        public string IdentficationNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string NigerianStates { get; set; }
        public string EmailAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string TemporaryAddress { get; set; }
        public string Landmark { get; set; }
        public string ClosestBusStop { get; set; }
        public string StateofResidence { get; set; }
        public int StateofResidence_FK { get; set; }
        public string ApplicationStatus { get; set; }
        public string ConvertedAmount { get; set; }
        public string TempStateofResidence { get; set; }
        public int TempStateofResidence_FK { get; set; }
        public string NyscStateofResidence { get; set; }
        public int NyscStateofResidence_FK { get; set; }
        public string TempLandmark { get; set; }
        public string TempClosestBusStop { get; set; }
        public string LGAs { get; set; }
        public int LGA_FK { get; set; }
        public string TempLGAs { get; set; }
        public int TempLGA_FK { get; set; }
        public string NyscLGAs { get; set; }
        public int NyscLGA_FK { get; set; }
        public string StateCode { get; set; }
        public string Organization { get; set; }
        public int AccomodationType_FK { get; set; }
        public string Employer { get; set; }
        public string PassOutMonth { get; set; }
        public string CDSDay { get; set; }
        public string CDSGroup { get; set; }
        public Double NetMonthlyIncome { get; set; }
        public string ApplicantID { get; set; }
        public string EMG_FullName { get; set; }
        public string PPA_Department { get; set; }
        public string PPA_ROle { get; set; }
        public string PPA_EmailAddress { get; set; }
        public string PPA_PhoneNumber { get; set; }
        public string PPA_supervisorName { get; set; }
        public string PPA_supervisorEmail { get; set; }
        public string PPA_supervisorPhonenumber { get; set; }

        public string EMG_HomeAddress { get; set; }
        public string EMG_PhoneNumber { get; set; }
        public string EMG_EmailAddress { get; set; }
        public string EMG_Relationship { get; set; }
        public string NOK_FullName { get; set; }

        public string NOK_Relationship { get; set; }
        public string NOK_PhoneNumber { get; set; }
        public string NOK_EmailAddress { get; set; }
        public string NOK_HomeAddress { get; set; }
        public Double LoanAmount { get; set; }
        public int LoanTenure { get; set; }
        public string LoanTenureStr { get; set; }
        public int RepaymentMethod_FK { get; set; }
        public bool ExistingLoan { get; set; }
        public Nullable<double> ExistingLoan_OutstandingAmount { get; set; }
        public int ExistingLoan_NoOfMonthsLeft { get; set; }
        public int Bank_FK { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string BVN { get; set; }
        public string ValueDate { get; set; }
        public string ValueTime { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public int ApplicationStatus_FK { get; set; }
        public string LoanComment { get; set; }
        public int IsVisible { get; set; }
        public string CreatedBy { get; set; }

        public int Recommend { get; set; }
        public string FirstRelativeName { get; set; }
        public string FirstRelativePhoneNumber { get; set; }
        public string SecondRelativeName { get; set; }
        public string SecondRelativePhoneNumber { get; set; }
        public string RelativeRelationship_FK { get; set; }
        public string RelativeRelationship2_FK { get; set; }

        public double SalaryAmount { get; set; }
        public string faculty { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }

        public string InstitutionAddress { get; set; }

        public string Designation { get; set; }

        public string Occupation { get; set; }

        public string LOS { get; set; }

        public string OfficialAddress { get; set; }
        public string OfficialEmail { get; set; }

        public int Contract { get; set; }

        public string BankCode { get; set; }

        public string NyscIdCardFilePath { get; set; }

        public string STA_FilePath { get; set; }
        public string NyscpassportFilePath { get; set; }
        public string NyscCallUpLetterFilePath { get; set; }
        public string NyscPostingLetterFllePath { get; set; }
        public string NyscProfileDashboardFilePath { get; set; }
        public string LetterOfundertaken { get; set; }
        
        public string ReferralCode { get; set; }
        public string RepaymentAmount { get; set; }

        public string bankcodes { get; set; }
    }


    public class data
    {
        public int InstiD { get; set; }
        public double TotalAmounyt { get; set; }
        public string RepaymentAmount { get; set; }
        public bool respMSg { get; set; }
        public string DateTimes { get; set; }

        public string responseMsg { get; set; }

        public string account_name { get; set; }
    }

    public class ExcelList
    {
        public int ID { get; set; }
        public string AccountName { get; set; }
        public string ApplicationStatus { get; set; }
        public string ConvertedAmount { get; set; }
        public string LoanRefNumber { get; set; }
        public string AccountNumber { get; set; }
        public string PermanentAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string Firstname { get; set; }
        public string ReferralCode { get; set; }
        public Double LoanAmount { get; set; }
        public int LoanTenure { get; set; }
        public string ValueDate { get; set; }

        public string Surname { get; set; }
        public string EmailAddress { get; set; }

        public string RemitaLink { get; set; }

    }
        public class ReferralRecords
        {
            public int ID { get; set; }
            

            public int User_FK { get; set; }
            

            public string ReferralCode { get; set; }
            

            public string TrnDate { get; set; }
            

            public string ReferenceNumber { get; set; }
            public Double Debit { get; set; }
            public Double Credit { get; set; }

            public string ValueDate { get; set; }
            public string ValueTime { get; set; }
           

        }




    public class ReferralDetails
    {
        public int ID { get; set; }


        public int User_FK { get; set; }


        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string EmailAddress { get; set; }


        public string UserAddress { get; set; }
        public string ContactAddress { get; set; }
        public string ReferralCode { get; set; }

        public string MyReferralCode { get; set; }
        public string ValueTime { get; set; }

        public string PhoneNumber { get; set; }

    }


    
    public class BVNRecords
    {
        public int ID { get; set; }


        public string Lastname { get; set; }


        public string Firstname { get; set; }


        public string Othernames { get; set; }


        public string DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string BankName { get; set; }

        public string EnrollmentBranch { get; set; }
        public string Nationlaity { get; set; }

        public string Marital_Status { get; set; }


        public string ContactAddress { get; set; }

        public int VerifiedStatus { get; set; }

        public string ServiceResponse { get; set; }

        public int IsVisible { get; set; }
        public string ValueDate { get; set; }


    }

    public class loanSummary
    {
        public int ID { get; set; }
        


        public string MyDate { get; set; }

        public int NoOfNewApplications { get; set; }

        

        public Double NewLoanAmount { get; set; }

        

        public int NoOfDisbursedApplications { get; set; }

        public Double DisbusredAmount { get; set; }
        


    }

    public class ReferralActivity
    {
        public int ID { get; set; }


        

        public string MyReferralCode { get; set; }

        public string Referrer { get; set; }

        

        public string EmailAddress { get; set; }


        

        public int NoOfLoan { get; set; }
        

        public Double LoanAmount { get; set; }



    }

    public class GetNYSCDefaultLoan
    {
     




        public string ReferenceNumber { get; set; }

        public string FullName { get; set; }



        public string StateCode { get; set; }




        public double LoanAmount { get; set; }


        public Double Amount { get; set; }

        public string DueMonth { get; set; }
    }


    public class IndividualBorrower
    {
        public string CustomerID { get; set; }
        public string BranchCode { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string DateOfBirth { get; set; }
        public string NationalIdentityNumber { get; set; }
        public string DriversLicenseNo { get; set; }
        public string BVNNo { get; set; }
        public string PassportNo { get; set; }
        public string Genders { get; set; }
        public string Nationality { get; set; }
        public string MaritalStatus { get; set; }
        public string MobileNumber { get; set; }
        public string PrimaryAddressLine1 { get; set; }
        public string PrimaryAddressLine2 { get; set; }
        public string PrimarycityLGA { get; set; }
        public string PrimaryState { get; set; }
        public string PrimaryCountry { get; set; }
        public string EmploymentStatus { get; set; }
        public string Occupation { get; set; }
        public string BusinessCategory { get; set; }
        public string BusinessSector { get; set; }
        public string BorrowerType { get; set; }
        public string OtherID { get; set; }
        public string TaxID { get; set; }
        public string PictureFilePath { get; set; }
        public string EmailAddress { get; set; }
        public string EmployerName { get; set; }
        public string EmployerAddressLine1 { get; set; }
        public string EmployerAddressLine2 { get; set; }
        public string EmployerCity { get; set; }
        public string EmployerState { get; set; }
        public string EmployerCountry { get; set; }
        public string Titles { get; set; }
        public string PlaceOfBirth { get; set; }
        public string WorkPhone { get; set; }
        public string HomePhone { get; set; }
        public string SecondaryAddressLine1 { get; set; }
        public string SecondaryAddressLine2 { get; set; }
        public string SecondaryAddressCityLGA { get; set; }
        public string SecondaryAddressState { get; set; }
        public string SecondaryAddressCountry { get; set; }
        public string SpouseSurname { get; set; }
        public string SpouseFirstName { get; set; }
        public string SpouseMiddleName { get; set; }

    }

    public class Invoice
    {
        public int LID { get; set; }
        public string Company { set; get; }
        public string Location { set; get; }

        public string ReferenceNum { set; get; }
        public string Fullname { set; get; }

        public DateTime DisburseDate { set; get; }

        public DateTime RepaymentDate { set; get; }

        public double Interestrate { set; get; }

        public double Credit { set; get; }

        public double Debit { set; get; }

        public int Tenure { get; set; }

        public double InterestPricipalDue { get; set; }

        public string EmployeeID { get; set; }

        public double AmountPaid { get; set; }
    }
}
