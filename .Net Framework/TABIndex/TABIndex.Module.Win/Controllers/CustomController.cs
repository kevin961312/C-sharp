using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win.Layout;
using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using TABIndex.Module.BusinessObjects;

namespace Gerencial7.Module.Win.Controllers.Infraestructure
{
    public class CustomWinController : ObjectViewController<DetailView, Person>, IModelExtender {
        protected override void OnActivated() {
            base.OnActivated();
            View.LayoutManager.LayoutCreated += this.LayoutManager_LayoutCreated;
            ((WinLayoutManager)View.LayoutManager).ItemCreated += this.WinLayoutManager_ItemCreated;
        }
        private void LayoutManager_LayoutCreated(object sender, EventArgs e) {
            ((WinLayoutManager)sender).Container.OptionsFocus.EnableAutoTabOrder = false;
        }
        private void WinLayoutManager_ItemCreated(object sender, ItemCreatedEventArgs e) {
            PropertyEditor editor = e.ViewItem as PropertyEditor;
            if(e.ModelLayoutElement is IModelLayoutItemTabIndex && editor != null) {
                int tabIndex = ((IModelLayoutItemTabIndex)e.ModelLayoutElement).TabIndex;
                if(tabIndex > -1) {
                    Control control = editor.Control as Control;
                    if(control != null) {
                        SetTabIndex(control, tabIndex);
                        SetTabStop(control as Control, editor.AllowEdit.ResultValue);
                    }
                    else {
                        editor.ControlCreated += (s1, e1) => {
                            var editor1 = (PropertyEditor)s1;
                            SetTabIndex(editor1.Control as Control, tabIndex);
                            SetTabStop(editor1.Control as Control, editor1.AllowEdit.ResultValue);
                        };
                        editor.AllowEditChanged += (s2, e2) => {
                            var editor2 = (PropertyEditor)s2;
                            SetTabStop(editor2.Control as Control, editor2.AllowEdit.ResultValue);
                        };
                    }
                }
            }
        }
        protected virtual void SetTabIndex(Control control, int tabIndex) {
            if(control != null) {
                control.TabIndex = tabIndex;
            }
        }
        protected virtual void SetTabStop(Control control, bool enabled) {
            BaseEdit baseEdit = control as BaseEdit;
            if(baseEdit != null) {
                baseEdit.TabStop = enabled;
            }
            else {
                control.TabStop = enabled;
            }
        }
        protected override void OnDeactivated() {
            if(View.LayoutManager != null) {
                View.LayoutManager.LayoutCreated -= this.LayoutManager_LayoutCreated;
            }
            base.OnDeactivated();
        }
        public void ExtendModelInterfaces(ModelInterfaceExtenders extenders) {
            extenders.Add<IModelViewLayoutElement, IModelLayoutItemTabIndex>();
        }
    }
    public interface IModelLayoutItemTabIndex {
        [DefaultValue(-1)]
        int TabIndex { get; set; }
    }
}
