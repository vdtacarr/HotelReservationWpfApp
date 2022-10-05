using FirstWpfApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWpfApp.Stores
{
    public class NavigationStore 
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel { get { return _currentViewModel; } set { _currentViewModel = value; OnCurrentViewModelChanged(); } }
        protected virtual void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
        public event Action CurrentViewModelChanged;
    }
}
