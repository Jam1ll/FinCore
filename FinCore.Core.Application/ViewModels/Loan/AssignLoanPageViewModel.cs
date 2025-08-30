using FinCore.Core.Application.ViewModels.User;

namespace FinCore.Core.Application.ViewModels.Loan
{
    public class AssignLoanPageViewModel
    {
        public AssignLoanViewModel? LoanData { get; set; }

        public List<UserViewModel>? Clients { get; set; }

        public AssignLoanPageViewModel()
        {
            LoanData = new AssignLoanViewModel();
            Clients = new List<UserViewModel>();
        }
    }
}