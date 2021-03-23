//using DevExpress.ExpressApp;
//using DevExpress.ExpressApp.Editors;
//using DevExpress.XtraLayout;
//using System.Collections.Generic;
//using System.Linq;
//using System.Windows.Forms;
//using TABIndex.Module.BusinessObjects;

//namespace Gerencial7.Module.Win.Controllers.Infraestructure
//{
//    public class CurrencyInternalTradeCaptureSetTabIndexController : ObjectViewController<DetailView, Person>
//    {
//        protected override void OnViewControlsCreated()
//        {
//            base.OnViewControlsCreated();

//            LayoutControl LayoutControl = this.View.Control as LayoutControl;
//            LayoutControl.OptionsFocus.EnableAutoTabOrder = false;
//            IList<PropertyEditor> PropertyEditors = this.View.GetItems<PropertyEditor>();

//            ((Control)PropertyEditors.First(propertyEditor
//                => propertyEditor.PropertyName == nameof(Person.Name)).Control).TabIndex = 0;
//            ((Control)PropertyEditors.First(propertyEditor
//                => propertyEditor.PropertyName == nameof(Person.Adress)).Control).TabIndex = 1;
//            ((Control)PropertyEditors.First(propertyEditor
//                => propertyEditor.PropertyName == nameof(Person.DoYouhaveEmail)).Control).TabIndex = 2;
//            ((Control)PropertyEditors.First(propertyEditor
//                => propertyEditor.PropertyName == nameof(Person.Email)).Control).TabIndex = 3;
//            ((Control)PropertyEditors.First(propertyEditor
//                => propertyEditor.PropertyName == nameof(Person.Age)).Control).TabIndex = 4;
//            ((Control)PropertyEditors.First(propertyEditor
//                => propertyEditor.PropertyName == nameof(Person.PhoneNumber)).Control).TabIndex = 5;

//        }
//    }
//}