﻿
namespace MySolution.Module.Controllers
{
    partial class ClearContactTasksController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClearTasksAction = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // ClearTasksAction
            // 
            this.ClearTasksAction.Caption = "Borrar tareas";
            this.ClearTasksAction.Category = "View";
            this.ClearTasksAction.ConfirmationMessage = "¿Está seguro de que desea borrar la lista de tareas?";
            this.ClearTasksAction.Id = "ClearTasksAction";
            this.ClearTasksAction.ImageName = "Action_Clear";
            this.ClearTasksAction.ToolTip = null;
            this.ClearTasksAction.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.ClearTasksAction_Execute);
            // 
            // ClearContactTasksController
            // 
            this.Actions.Add(this.ClearTasksAction);
            this.Tag = "MySolution.Module.BusinessObjects.Contact ";
            this.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction ClearTasksAction;
    }
}
