using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.entities
{
    public partial class EntityForm<T> : Form where T : class
    {
        public T Entity { get; set; }
        public bool IsNew { get; set; }

        protected virtual Label LblId { get; }
        protected virtual Button BtnAccept { get; }
        protected virtual Button BtnCancel { get; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BtnAccept.Click += btnAccept_Click;
            BtnCancel.Click += btnCancel_Click;

            if (IsNew)
            {
                this.Text = $"Add {typeof(T).Name}";
                LblId.Visible = false;
            }
            else
            {
                this.Text = $"Edit {typeof(T).Name}";
                LblId.Visible = true;
                DisplayEntity();
            }
        }

        protected virtual void DisplayEntity() { }
        protected virtual bool Validation() { return true; }
        protected virtual void UpdateEntity() { }

        protected virtual void btnAccept_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                UpdateEntity();
                this.DialogResult = DialogResult.OK;
            }
        }

        protected virtual void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
