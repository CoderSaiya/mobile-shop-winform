using MaterialSkin.Controls;

namespace MobileShop.UI.Forms.Views
{
    partial class ConfirmPurchaseForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // Form size and padding
            ClientSize = new Size(450, 600);
            Padding = new Padding(20);

            // Info Label
            lblInfo = new MaterialLabel
            {
                Text = $"IMEI: {_imei}  –  Model: {_model}  –  Price: {_price:C}",
                Location = new Point(20, 90),
                AutoSize = true
            };

            // Vertical spacing
            int top = 130;
            int spacing = 80;
            //
            // lblName
            //
            var lblName = new MaterialLabel { Text = "Customer Name:", Location = new Point(20, top), AutoSize = true };
            txtName = new MaterialTextBox { Hint = "Enter full name", Location = new Point(20, top + 25), Size = new Size(360, 48) };
            top += spacing + 10;
            //
            // lblMobile
            //
            var lblMobile = new MaterialLabel { Text = "Mobile Number:", Location = new Point(20, top), AutoSize = true };
            txtMobile = new MaterialTextBox { Hint = "+1234567890 or 0123456789", Location = new Point(20, top + 25), Size = new Size(360, 48) };
            top += spacing + 10;
            //
            // lblEmail
            //
            var lblEmail = new MaterialLabel { Text = "Email:", Location = new Point(20, top), AutoSize = true };
            txtEmail = new MaterialTextBox { Hint = "email@example.com", Location = new Point(20, top + 25), Size = new Size(360, 48) };
            top += spacing + 10;
            //
            // lblAddress
            //
            var lblAddress = new MaterialLabel { Text = "Address:", Location = new Point(20, top), AutoSize = true };
            txtAddress = new MaterialTextBox { Hint = "Customer address", Location = new Point(20, top + 25), Size = new Size(360, 48) };
            top += spacing + 20;
            //
            // btnCancel
            //
            btnCancel = new MaterialButton { Text = "Cancel", Location = new Point(200, top), AutoSize = true };
            btnCancel.Click += btnCancel_Click;
            //
            // btnConfirm
            //
            btnConfirm = new MaterialButton { Text = "Confirm", Location = new Point(290, top), AutoSize = true };
            btnConfirm.Click += btnConfirm_Click;

            // Add to form
            Controls.AddRange(new Control[] {
                lblInfo,
                lblName, txtName,
                lblMobile, txtMobile,
                lblEmail, txtEmail,
                lblAddress, txtAddress,
                btnCancel, btnConfirm
            });
        }

        #endregion

        private MaterialLabel lblInfo;
        private MaterialTextBox txtName;
        private MaterialTextBox txtMobile;
        private MaterialTextBox txtEmail;
        private MaterialTextBox txtAddress;
        private MaterialButton btnConfirm;
        private MaterialButton btnCancel;
    }
}