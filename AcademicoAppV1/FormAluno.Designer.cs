namespace AcademicoAppV1
{
    partial class FormAluno
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAluno));
            TabControlCadastro = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btn_Cancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            txtCidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBairro = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtEndereco = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboEstado = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDataNascimento = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPageConsulta = new TabPage();
            listViewConsulta = new ListView();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            TabControlCadastro.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Controls.Add(tabPageCadastro);
            TabControlCadastro.Controls.Add(tabPageConsulta);
            TabControlCadastro.Depth = 0;
            TabControlCadastro.ImageList = imageList1;
            TabControlCadastro.Location = new Point(6, 67);
            TabControlCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TabControlCadastro.Multiline = true;
            TabControlCadastro.Name = "TabControlCadastro";
            TabControlCadastro.SelectedIndex = 0;
            TabControlCadastro.Size = new Size(729, 429);
            TabControlCadastro.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtSenha);
            tabPageCadastro.Controls.Add(btn_Cancelar);
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.Controls.Add(txtCidade);
            tabPageCadastro.Controls.Add(txtBairro);
            tabPageCadastro.Controls.Add(txtEndereco);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(cboEstado);
            tabPageCadastro.Controls.Add(txtDataNascimento);
            tabPageCadastro.Controls.Add(txtMatricula);
            tabPageCadastro.ImageKey = "form.png";
            tabPageCadastro.Location = new Point(4, 31);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(721, 394);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = Properties.Resources.baseline_fingerprint_black_24dp;
            txtSenha.Location = new Point(34, 276);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(599, 48);
            txtSenha.TabIndex = 9;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = false;
            // 
            // btn_Cancelar
            // 
            btn_Cancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btn_Cancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btn_Cancelar.Depth = 0;
            btn_Cancelar.HighEmphasis = true;
            btn_Cancelar.Icon = null;
            btn_Cancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btn_Cancelar.Location = new Point(448, 333);
            btn_Cancelar.Margin = new Padding(4, 6, 4, 6);
            btn_Cancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btn_Cancelar.Name = "btn_Cancelar";
            btn_Cancelar.NoAccentTextColor = Color.Empty;
            btn_Cancelar.Size = new Size(96, 36);
            btn_Cancelar.TabIndex = 8;
            btn_Cancelar.Text = "Cancelar";
            btn_Cancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btn_Cancelar.UseAccentColor = false;
            btn_Cancelar.UseVisualStyleBackColor = true;
            btn_Cancelar.Click += btn_Cancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(557, 333);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtCidade
            // 
            txtCidade.AnimateReadOnly = false;
            txtCidade.AutoCompleteMode = AutoCompleteMode.None;
            txtCidade.AutoCompleteSource = AutoCompleteSource.None;
            txtCidade.BackgroundImageLayout = ImageLayout.None;
            txtCidade.CharacterCasing = CharacterCasing.Normal;
            txtCidade.Depth = 0;
            txtCidade.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCidade.HideSelection = true;
            txtCidade.Hint = "Cidade";
            txtCidade.LeadingIcon = null;
            txtCidade.Location = new Point(34, 222);
            txtCidade.MaxLength = 32767;
            txtCidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCidade.Name = "txtCidade";
            txtCidade.PasswordChar = '\0';
            txtCidade.PrefixSuffixText = null;
            txtCidade.ReadOnly = false;
            txtCidade.RightToLeft = RightToLeft.No;
            txtCidade.SelectedText = "";
            txtCidade.SelectionLength = 0;
            txtCidade.SelectionStart = 0;
            txtCidade.ShortcutsEnabled = true;
            txtCidade.Size = new Size(599, 48);
            txtCidade.TabIndex = 6;
            txtCidade.TabStop = false;
            txtCidade.TextAlign = HorizontalAlignment.Left;
            txtCidade.TrailingIcon = null;
            txtCidade.UseSystemPasswordChar = false;
            // 
            // txtBairro
            // 
            txtBairro.AnimateReadOnly = false;
            txtBairro.AutoCompleteMode = AutoCompleteMode.None;
            txtBairro.AutoCompleteSource = AutoCompleteSource.None;
            txtBairro.BackgroundImageLayout = ImageLayout.None;
            txtBairro.CharacterCasing = CharacterCasing.Normal;
            txtBairro.Depth = 0;
            txtBairro.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBairro.HideSelection = true;
            txtBairro.Hint = "Bairro";
            txtBairro.LeadingIcon = null;
            txtBairro.Location = new Point(34, 168);
            txtBairro.MaxLength = 32767;
            txtBairro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBairro.Name = "txtBairro";
            txtBairro.PasswordChar = '\0';
            txtBairro.PrefixSuffixText = null;
            txtBairro.ReadOnly = false;
            txtBairro.RightToLeft = RightToLeft.No;
            txtBairro.SelectedText = "";
            txtBairro.SelectionLength = 0;
            txtBairro.SelectionStart = 0;
            txtBairro.ShortcutsEnabled = true;
            txtBairro.Size = new Size(456, 48);
            txtBairro.TabIndex = 5;
            txtBairro.TabStop = false;
            txtBairro.TextAlign = HorizontalAlignment.Left;
            txtBairro.TrailingIcon = null;
            txtBairro.UseSystemPasswordChar = false;
            // 
            // txtEndereco
            // 
            txtEndereco.AnimateReadOnly = false;
            txtEndereco.AutoCompleteMode = AutoCompleteMode.None;
            txtEndereco.AutoCompleteSource = AutoCompleteSource.None;
            txtEndereco.BackgroundImageLayout = ImageLayout.None;
            txtEndereco.CharacterCasing = CharacterCasing.Normal;
            txtEndereco.Depth = 0;
            txtEndereco.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEndereco.HideSelection = true;
            txtEndereco.Hint = "Endereço";
            txtEndereco.LeadingIcon = null;
            txtEndereco.Location = new Point(34, 114);
            txtEndereco.MaxLength = 32767;
            txtEndereco.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.PasswordChar = '\0';
            txtEndereco.PrefixSuffixText = null;
            txtEndereco.ReadOnly = false;
            txtEndereco.RightToLeft = RightToLeft.No;
            txtEndereco.SelectedText = "";
            txtEndereco.SelectionLength = 0;
            txtEndereco.SelectionStart = 0;
            txtEndereco.ShortcutsEnabled = true;
            txtEndereco.Size = new Size(599, 48);
            txtEndereco.TabIndex = 4;
            txtEndereco.TabStop = false;
            txtEndereco.TextAlign = HorizontalAlignment.Left;
            txtEndereco.TrailingIcon = null;
            txtEndereco.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(34, 60);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(599, 48);
            txtNome.TabIndex = 3;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // cboEstado
            // 
            cboEstado.AutoResize = false;
            cboEstado.BackColor = Color.FromArgb(255, 255, 255);
            cboEstado.Depth = 0;
            cboEstado.DrawMode = DrawMode.OwnerDrawVariable;
            cboEstado.DropDownHeight = 174;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.DropDownWidth = 121;
            cboEstado.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboEstado.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboEstado.FormattingEnabled = true;
            cboEstado.Hint = "UF";
            cboEstado.IntegralHeight = false;
            cboEstado.ItemHeight = 43;
            cboEstado.Items.AddRange(new object[] { "SP - São Paulo", "RJ - Rio de Janeiro", "AC - Acre" });
            cboEstado.Location = new Point(512, 167);
            cboEstado.MaxDropDownItems = 4;
            cboEstado.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(121, 49);
            cboEstado.StartIndex = 0;
            cboEstado.TabIndex = 2;
            // 
            // txtDataNascimento
            // 
            txtDataNascimento.AllowPromptAsInput = true;
            txtDataNascimento.AnimateReadOnly = false;
            txtDataNascimento.AsciiOnly = false;
            txtDataNascimento.BackgroundImageLayout = ImageLayout.None;
            txtDataNascimento.BeepOnError = false;
            txtDataNascimento.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNascimento.Depth = 0;
            txtDataNascimento.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataNascimento.HidePromptOnLeave = false;
            txtDataNascimento.HideSelection = true;
            txtDataNascimento.Hint = "Data Nascimento";
            txtDataNascimento.InsertKeyMode = InsertKeyMode.Default;
            txtDataNascimento.LeadingIcon = null;
            txtDataNascimento.Location = new Point(438, 6);
            txtDataNascimento.Mask = "99/99/99";
            txtDataNascimento.MaxLength = 32767;
            txtDataNascimento.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataNascimento.Name = "txtDataNascimento";
            txtDataNascimento.PasswordChar = '\0';
            txtDataNascimento.PrefixSuffixText = null;
            txtDataNascimento.PromptChar = '_';
            txtDataNascimento.ReadOnly = false;
            txtDataNascimento.RejectInputOnFirstFailure = false;
            txtDataNascimento.ResetOnPrompt = true;
            txtDataNascimento.ResetOnSpace = true;
            txtDataNascimento.RightToLeft = RightToLeft.No;
            txtDataNascimento.SelectedText = "";
            txtDataNascimento.SelectionLength = 0;
            txtDataNascimento.SelectionStart = 0;
            txtDataNascimento.ShortcutsEnabled = true;
            txtDataNascimento.Size = new Size(195, 48);
            txtDataNascimento.SkipLiterals = true;
            txtDataNascimento.TabIndex = 1;
            txtDataNascimento.TabStop = false;
            txtDataNascimento.Text = "  /  /";
            txtDataNascimento.TextAlign = HorizontalAlignment.Left;
            txtDataNascimento.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataNascimento.TrailingIcon = null;
            txtDataNascimento.UseSystemPasswordChar = false;
            txtDataNascimento.ValidatingType = null;
            // 
            // txtMatricula
            // 
            txtMatricula.AnimateReadOnly = false;
            txtMatricula.AutoCompleteMode = AutoCompleteMode.None;
            txtMatricula.AutoCompleteSource = AutoCompleteSource.None;
            txtMatricula.BackgroundImageLayout = ImageLayout.None;
            txtMatricula.CharacterCasing = CharacterCasing.Normal;
            txtMatricula.Depth = 0;
            txtMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatricula.HideSelection = true;
            txtMatricula.Hint = "Matricula";
            txtMatricula.LeadingIcon = null;
            txtMatricula.Location = new Point(34, 6);
            txtMatricula.MaxLength = 32767;
            txtMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PasswordChar = '\0';
            txtMatricula.PrefixSuffixText = null;
            txtMatricula.ReadOnly = false;
            txtMatricula.RightToLeft = RightToLeft.No;
            txtMatricula.SelectedText = "";
            txtMatricula.SelectionLength = 0;
            txtMatricula.SelectionStart = 0;
            txtMatricula.ShortcutsEnabled = true;
            txtMatricula.Size = new Size(327, 48);
            txtMatricula.TabIndex = 0;
            txtMatricula.TabStop = false;
            txtMatricula.TextAlign = HorizontalAlignment.Left;
            txtMatricula.TrailingIcon = null;
            txtMatricula.UseSystemPasswordChar = false;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(listViewConsulta);
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.ImageKey = "search.png";
            tabPageConsulta.Location = new Point(4, 31);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(721, 394);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // listViewConsulta
            // 
            listViewConsulta.Location = new Point(0, 0);
            listViewConsulta.Name = "listViewConsulta";
            listViewConsulta.Size = new Size(722, 222);
            listViewConsulta.TabIndex = 4;
            listViewConsulta.UseCompatibleStateImageBehavior = false;
            listViewConsulta.View = View.Details;
            listViewConsulta.Enter += tabPageConsulta_Enter;
            listViewConsulta.MouseDoubleClick += listViewConsulta_MouseDoubleClick;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(642, 231);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(563, 231);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(491, 231);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 1;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "search.png");
            imageList1.Images.SetKeyName(1, "form.png");
            // 
            // FormAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 565);
            Controls.Add(TabControlCadastro);
            DrawerTabControl = TabControlCadastro;
            Name = "FormAluno";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de  Alunos";
            TabControlCadastro.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl TabControlCadastro;
        private TabPage tabPageCadastro;
        private TabPage tabPageConsulta;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEndereco;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialComboBox cboEstado;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataNascimento;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCidade;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBairro;
        private ReaLTaiizor.Controls.MaterialButton btn_Cancelar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private ListView listViewConsulta;
    }
}