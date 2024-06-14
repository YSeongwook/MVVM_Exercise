using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using ViewModel;
using ViewModel.Extensions;

public class TopLeftUIView : MonoBehaviour
{
    [SerializeField] Text Text_Name;
    [SerializeField] Text Text_Level;
    [SerializeField] Image Image_Icon;

    private TopLeftViewModel _vm;

    private void OnEnable()
    {
        if (_vm == null)
        {
            _vm = new TopLeftViewModel();
            _vm.PropertyChanged += OnPropertyChanged;
            _vm.RegisterEventOnEnable();
            _vm.RefreshViewModel();
        }
    }

    private void OnDisable()
    {
        if (_vm != null)
        {
            _vm.UnRegisterEventOnDisable();
            _vm.PropertyChanged -= OnPropertyChanged;
            _vm = null;
        }
    }

    private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        switch (e.PropertyName)
        {
            case nameof(_vm.Name):
                Text_Name.text = _vm.Name;
                break;
            case nameof(_vm.Level):
                Text_Level.text = $"Lv.{_vm.Level}";
                break;
            case nameof(_vm.IconName):
                break;
        }
    }
}