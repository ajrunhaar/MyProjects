using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel

namespace EntryManager.ViewModels
{
    class MainEntryViewModel : INotifyPropertyChanged
    {
        Models.MainEntryModel _mainEntryModel;

        public MainEntryViewModel(){
            _mainEntryModel = new Models.MainEntryModel{EntryName = "Test Name",EntryHome = "Test Home",EntryID=123};
        }

        public string Name
        {
            get { return _mainEntryModel.EntryName; }
            set { _mainEntryModel.EntryName = value; }
        }

        public string Home
        {
            get { return _mainEntryModel.EntryHome; }
            set { _mainEntryModel.EntryHome = value; }
        }

        public int ID
        {
            get { return _mainEntryModel.EntryID; }
            set { _mainEntryModel.EntryID = value; }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propertyName){
            PropertyChangedEventHandler handler = PropertyChanged;
            if(handler!=null){
                handler(this,new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
