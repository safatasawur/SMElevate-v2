using SMElevate.Web.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace SMElevate.Web.Areas.EndUser.ViewModels;

public class EndUserLoginViewModel
{
    [Required, EmailAddress] public string Email { get; set; } = default!;
    [Required] public string Password { get; set; } = default!;
}

public class EndUserRegisterViewModel
{
    [Required] public string FullName { get; set; } = default!;
    [Required, EmailAddress] public string Email { get; set; } = default!;
    public string? MobileNo { get; set; }
    [Required, MinLength(6)] public string Password { get; set; } = default!;
    public bool AgreeTerms { get; set; }
}

public class ProfileCompleteViewModel
{
    [Required] public string FirstName { get; set; } = default!;
    [Required] public string LastName { get; set; } = default!;
    [Required] public string MobileNo { get; set; } = default!;
    [Required] public string CNIC { get; set; } = default!;
    [Required, EmailAddress] public string BusinessEmailAddress { get; set; } = default!;
    [Required] public string GenderOfProprietor { get; set; } = default!;
}

public class TokenVerifyViewModel
{
    [Required] public string Token { get; set; } = default!;
}

public class LoanRequestCreateViewModel
{
    // Dynamic form binding (populated when scheme is selected)
    public int? SchemeId { get; set; }
    public int? SchemeFormId { get; set; }
    public string? FieldValuesJson { get; set; }

    // Classic fixed fields (still used for model binding when dynamic form matches field names)
    public string? NameOfBusiness { get; set; }
    public string? ContactPerson { get; set; }
    public string? CellOrLandlineNo { get; set; }
    public string? BusinessAddress { get; set; }
    public decimal? AnnualSales { get; set; }
    public int? YearOfEstablishment { get; set; }
    public int? NoOfEmployees { get; set; }
    public string? NTNNo { get; set; }
    public string? BusinessPremise { get; set; }
    public bool IsBusinessRegistered { get; set; }
    public string? RegistrationAuthority { get; set; }
    public string? BusinessStatus { get; set; }
    public string? BusinessNature { get; set; }
    public string? BusinessDescription { get; set; }
    public string? FacilityRequested { get; set; }
    public string? TypeOfFacility { get; set; }
    public decimal? Amount { get; set; }
    public int? Tenor { get; set; }
    public int? AssignedBankId { get; set; }
    public string? IBANOrRaastType { get; set; }
    public string? IBANOrRaastValue { get; set; }
    public string? PreferredIdentifierType { get; set; }
    public bool ConsentGiven { get; set; }
    public bool SaveAsDraft { get; set; }
    public List<ShareholderRowViewModel> Shareholders { get; set; } = new();

    // Lookup data for GET
    public List<Scheme> Schemes { get; set; } = new();
    public List<Bank> Banks { get; set; } = new();
    public List<MasterLookupValue> BusinessNatures { get; set; } = new();
    public List<MasterLookupValue> FacilityTypes { get; set; } = new();
    public List<MasterLookupValue> BusinessStatuses { get; set; } = new();
    public List<MasterLookupValue> BusinessPremises { get; set; } = new();
    public List<MasterLookupValue> Tenors { get; set; } = new();
}

public class ShareholderRowViewModel
{
    public string Name { get; set; } = default!;
    public string? ContactNo { get; set; }
    public string? Email { get; set; }
    public string? CNIC { get; set; }
    public decimal ShareholdingPercentage { get; set; }
}

public class LoanApplicationDetailViewModel
{
    public LoanRequest Request { get; set; } = default!;
    public List<LoanRequestStatusHistory> StatusHistory { get; set; } = new();
    public List<AdditionalInformationRequest> InfoRequests { get; set; } = new();
    public ConditionalOffer? ActiveOffer { get; set; }
    public List<ConditionalOffer> AllOffers { get; set; } = new();
    public BankDecision? Decision { get; set; }
    public Disbursement? Disbursement { get; set; }
    public PostApprovalChecklist? Checklist { get; set; }
    public List<ApplicationDocument> Documents { get; set; } = new();
    public List<WorkflowTransition> AllowedTransitions { get; set; } = new();
}

public class InfoRequestResponseViewModel
{
    [Required] public int RequestId { get; set; }
    [Required, MaxLength(2000)] public string Response { get; set; } = default!;
    public List<IFormFile>? Documents { get; set; }
}

public class OfferResponseViewModel
{
    [Required] public int OfferId { get; set; }
    [Required] public string ResponseType { get; set; } = default!; // Accepted | Rejected
    public string? Remarks { get; set; }
}

public class EndUserDashboardViewModel
{
    public int TotalApplications { get; set; }
    public int DraftApplications { get; set; }
    public int SubmittedApplications { get; set; }
    public int PendingActions { get; set; }
    public int ActiveOffers { get; set; }
    public int DisbursedApplications { get; set; }
    public List<AppNotification> RecentNotifications { get; set; } = new();
    public List<LoanRequest> RecentApplications { get; set; } = new();
    public int UnreadNotifications { get; set; }
}
