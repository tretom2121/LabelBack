using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelBack.Viewmodel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            RollContentCommand = new DelegateCommand(exec =>
            {
                if (LabelContent != "Failed")
                {
                    LabelContent = "Failed";
                    return;
                }

                LabelContent = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            });
        }

        private string _labelContent;
        public string LabelContent
        {
            get { return _labelContent; }
            set 
            { 
                _labelContent = value;
                OnPropertyChanged();
            }
        }


        public DelegateCommand RollContentCommand { get; set; }
    }
}
