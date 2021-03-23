using DevExpress.ExpressApp;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.Persistent.BaseImpl;
using MySolution.Module.BusinessObjects;
using System;
using System.Collections.Generic;

namespace MySolution.Module.Controllers
{
    public partial class SaveDropListController : ViewController
    {
        protected override void OnActivated()
        {
            base.OnActivated();
            NewObjectViewController controller = Frame.GetController<NewObjectViewController>();
            if (controller != null)
            {
                controller.CollectCreatableItemTypes += NewObjectViewController_CollectCreatableItemTypes;
                if (controller.Active)
                {
                    controller.UpdateNewObjectAction();
                }
            }
        }
        private void NewObjectViewController_CollectCreatableItemTypes(object sender, CollectTypesEventArgs e)
        {
            CustomizeList(e.Types);
        }
        private void CustomizeList(ICollection<Type> types)
        {
            List<Type> unusableTypes = new List<Type>();
            foreach (Type item in types)
            {
                unusableTypes.Add(item);
            }
            foreach (Type item in unusableTypes)
            {
                types.Remove(item);
            }
        }
        protected override void OnDeactivated()
        {
            NewObjectViewController controller = Frame.GetController<NewObjectViewController>();
            if (controller != null)
            {
                controller.CollectCreatableItemTypes -= NewObjectViewController_CollectCreatableItemTypes;
            }
            base.OnDeactivated();
        }
    }
}
