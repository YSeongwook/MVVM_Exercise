using System.ComponentModel;
using UnityEngine;

namespace ViewModel
{
    public class TopLeftViewModel : MonoBehaviour
    {
        private string _name;
        private int _level;
        private string _iconName;
    
        public int UserId { get; set; }
    
        public string Name
        {
            get => _name;
            set
            {
                if (_name == value) return;
    
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
    
        public int Level
        {
            get => _level;
            set
            {
                if (_level == value) return;
                
                _level = value;
                OnPropertyChanged(nameof(Level));
            }
        }
    
        public string IconName
        {
            get => _iconName;
            set
            {
                if (_iconName == value) return;
                
                _iconName = value;
                OnPropertyChanged(nameof(IconName));
            }
        }
    
    
        #region PropChanged
    
        public event PropertyChangedEventHandler PropertyChanged;
    
        protected virtual void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    
        #endregion
    }
}
