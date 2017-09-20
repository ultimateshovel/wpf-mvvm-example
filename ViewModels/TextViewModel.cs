using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp.ViewModels
{
    using Models;
    using Prism.Mvvm;

    public class TextViewModel : BindableBase
    {
        private ITextModel _textModel;
        public TextViewModel(ITextModel textModel)
        {
            _textModel = textModel;
        }
    }
}
