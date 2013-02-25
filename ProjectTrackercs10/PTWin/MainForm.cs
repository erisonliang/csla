using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.Security.Principal;
using System.Configuration;
using CSLA.Security;
using ProjectTracker.Library;

namespace PTWin
{
	/// <summary>
	/// Summary description for Main.
	/// </summary>
  public class MainForm : System.Windows.Forms.Form
  {
    private System.Windows.Forms.MainMenu mainMenu1;
    private System.Windows.Forms.MenuItem menuItem1;
    private System.Windows.Forms.MenuItem menuItem2;
    private System.Windows.Forms.MenuItem menuItem5;
    private System.Windows.Forms.MenuItem menuItem7;
    private System.Windows.Forms.MenuItem menuItem8;
    private System.Windows.Forms.MenuItem mnuFileLogin;
    private System.Windows.Forms.MenuItem mnuFileLogout;
    private System.Windows.Forms.MenuItem mnuFileExit;
    private System.Windows.Forms.MenuItem mnuProjectNew;
    private System.Windows.Forms.MenuItem mnuProjectEdit;
    private System.Windows.Forms.MenuItem mnuProjectRemove;
    private System.Windows.Forms.MenuItem mnuResourceNew;
    private System.Windows.Forms.MenuItem mnuResourceEdit;
    private System.Windows.Forms.MenuItem mnuResourceRemove;
    private System.Windows.Forms.StatusBar statusBar1;
    private System.Windows.Forms.StatusBarPanel pnlStatus;
    private System.Windows.Forms.StatusBarPanel pnlUser;
    private System.Windows.Forms.MenuItem menuItem3;
    private System.Windows.Forms.MenuItem mnuProjectUpdate;
    private System.Windows.Forms.MenuItem menuItem4;
    private System.Windows.Forms.MenuItem mnuProjectList;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.Container components = null;

    public MainForm()
    {
      //
      // Required for Windows Form Designer support
      //
      InitializeComponent();

      //
      // TODO: Add any constructor code after InitializeComponent call
      //
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    protected override void Dispose( bool disposing )
    {
      if( disposing )
      {
        if(components != null)
        {
          components.Dispose();
        }
      }
      base.Dispose( disposing );
    }

		#region Windows Form Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.mainMenu1 = new System.Windows.Forms.MainMenu();
      this.menuItem1 = new System.Windows.Forms.MenuItem();
      this.mnuFileLogin = new System.Windows.Forms.MenuItem();
      this.mnuFileLogout = new System.Windows.Forms.MenuItem();
      this.menuItem5 = new System.Windows.Forms.MenuItem();
      this.mnuFileExit = new System.Windows.Forms.MenuItem();
      this.menuItem2 = new System.Windows.Forms.MenuItem();
      this.menuItem7 = new System.Windows.Forms.MenuItem();
      this.mnuProjectNew = new System.Windows.Forms.MenuItem();
      this.mnuProjectEdit = new System.Windows.Forms.MenuItem();
      this.mnuProjectRemove = new System.Windows.Forms.MenuItem();
      this.menuItem8 = new System.Windows.Forms.MenuItem();
      this.mnuResourceNew = new System.Windows.Forms.MenuItem();
      this.mnuResourceEdit = new System.Windows.Forms.MenuItem();
      this.mnuResourceRemove = new System.Windows.Forms.MenuItem();
      this.menuItem3 = new System.Windows.Forms.MenuItem();
      this.mnuProjectUpdate = new System.Windows.Forms.MenuItem();
      this.statusBar1 = new System.Windows.Forms.StatusBar();
      this.pnlStatus = new System.Windows.Forms.StatusBarPanel();
      this.pnlUser = new System.Windows.Forms.StatusBarPanel();
      this.menuItem4 = new System.Windows.Forms.MenuItem();
      this.mnuProjectList = new System.Windows.Forms.MenuItem();
      ((System.ComponentModel.ISupportInitialize)(this.pnlStatus)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pnlUser)).BeginInit();
      this.SuspendLayout();
      // 
      // mainMenu1
      // 
      this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                              this.menuItem1,
                                                                              this.menuItem2,
                                                                              this.menuItem4,
                                                                              this.menuItem3});
      // 
      // menuItem1
      // 
      this.menuItem1.Index = 0;
      this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                              this.mnuFileLogin,
                                                                              this.mnuFileLogout,
                                                                              this.menuItem5,
                                                                              this.mnuFileExit});
      this.menuItem1.Text = "&File";
      // 
      // mnuFileLogin
      // 
      this.mnuFileLogin.Index = 0;
      this.mnuFileLogin.Text = "&Login";
      this.mnuFileLogin.Click += new System.EventHandler(this.mnuFileLogin_Click);
      // 
      // mnuFileLogout
      // 
      this.mnuFileLogout.Index = 1;
      this.mnuFileLogout.Text = "L&ogout";
      this.mnuFileLogout.Click += new System.EventHandler(this.mnuFileLogout_Click);
      // 
      // menuItem5
      // 
      this.menuItem5.Index = 2;
      this.menuItem5.Text = "-";
      // 
      // mnuFileExit
      // 
      this.mnuFileExit.Index = 3;
      this.mnuFileExit.Text = "E&xit";
      this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
      // 
      // menuItem2
      // 
      this.menuItem2.Index = 1;
      this.menuItem2.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                              this.menuItem7,
                                                                              this.menuItem8});
      this.menuItem2.Text = "&Action";
      // 
      // menuItem7
      // 
      this.menuItem7.Index = 0;
      this.menuItem7.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                              this.mnuProjectNew,
                                                                              this.mnuProjectEdit,
                                                                              this.mnuProjectRemove});
      this.menuItem7.Text = "&Project";
      // 
      // mnuProjectNew
      // 
      this.mnuProjectNew.Index = 0;
      this.mnuProjectNew.Text = "&New";
      this.mnuProjectNew.Click += new System.EventHandler(this.mnuProjectNew_Click);
      // 
      // mnuProjectEdit
      // 
      this.mnuProjectEdit.Index = 1;
      this.mnuProjectEdit.Text = "&Edit";
      this.mnuProjectEdit.Click += new System.EventHandler(this.mnuProjectEdit_Click);
      // 
      // mnuProjectRemove
      // 
      this.mnuProjectRemove.Index = 2;
      this.mnuProjectRemove.Text = "&Remove";
      this.mnuProjectRemove.Click += new System.EventHandler(this.mnuProjectRemove_Click);
      // 
      // menuItem8
      // 
      this.menuItem8.Index = 1;
      this.menuItem8.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                              this.mnuResourceNew,
                                                                              this.mnuResourceEdit,
                                                                              this.mnuResourceRemove});
      this.menuItem8.Text = "&Resource";
      // 
      // mnuResourceNew
      // 
      this.mnuResourceNew.Index = 0;
      this.mnuResourceNew.Text = "&New";
      this.mnuResourceNew.Click += new System.EventHandler(this.mnuResourceNew_Click);
      // 
      // mnuResourceEdit
      // 
      this.mnuResourceEdit.Index = 1;
      this.mnuResourceEdit.Text = "&Edit";
      this.mnuResourceEdit.Click += new System.EventHandler(this.mnuResourceEdit_Click);
      // 
      // mnuResourceRemove
      // 
      this.mnuResourceRemove.Index = 2;
      this.mnuResourceRemove.Text = "&Remove";
      this.mnuResourceRemove.Click += new System.EventHandler(this.mnuResourceRemove_Click);
      // 
      // menuItem3
      // 
      this.menuItem3.Index = 3;
      this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                              this.mnuProjectUpdate});
      this.menuItem3.Text = "&Batch";
      // 
      // mnuProjectUpdate
      // 
      this.mnuProjectUpdate.Index = 0;
      this.mnuProjectUpdate.Text = "&Project update";
      this.mnuProjectUpdate.Click += new System.EventHandler(this.mnuProjectUpdate_Click);
      // 
      // statusBar1
      // 
      this.statusBar1.Location = new System.Drawing.Point(0, 244);
      this.statusBar1.Name = "statusBar1";
      this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
                                                                                  this.pnlStatus,
                                                                                  this.pnlUser});
      this.statusBar1.ShowPanels = true;
      this.statusBar1.Size = new System.Drawing.Size(816, 22);
      this.statusBar1.TabIndex = 1;
      this.statusBar1.Text = "statusBar1";
      // 
      // pnlStatus
      // 
      this.pnlStatus.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
      this.pnlStatus.Width = 700;
      // 
      // menuItem4
      // 
      this.menuItem4.Index = 2;
      this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                                                              this.mnuProjectList});
      this.menuItem4.Text = "&Reports";
      // 
      // mnuProjectList
      // 
      this.mnuProjectList.Index = 0;
      this.mnuProjectList.Text = "&Project list";
      this.mnuProjectList.Click += new System.EventHandler(this.mnuProjectList_Click);
      // 
      // MainForm
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(816, 266);
      this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                  this.statusBar1});
      this.IsMdiContainer = true;
      this.Menu = this.mainMenu1;
      this.Name = "MainForm";
      this.Text = "Project Tracker";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pnlStatus)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pnlUser)).EndInit();
      this.ResumeLayout(false);

    }
		#endregion

    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() 
    {
      Application.Run(new MainForm());
    }

    #region Load and Exit

    private void MainForm_Load(object sender, System.EventArgs e)
    {
      _main = this;

      if(ConfigurationSettings.AppSettings["Authentication"] == "Windows")
      {
        mnuFileLogin.Visible = false;
        AppDomain.CurrentDomain.SetPrincipalPolicy(
          PrincipalPolicy.WindowsPrincipal);
        EnableMenus();
      }
      else
        DoLogin();
    }

    private void mnuFileExit_Click(object sender, System.EventArgs e)
    {
      Close();
    }

    #endregion

    #region Login/Logout/Authorization

    private void mnuFileLogin_Click(object sender, System.EventArgs e)
    {
      DoLogin();
    }

    private void mnuFileLogout_Click(object sender, System.EventArgs e)
    {
      DoLogout();
    }

    void DoLogin()
    {
      Login dlg = new Login();

      if(dlg.ShowDialog(this) == DialogResult.OK)
      {
        Cursor = Cursors.WaitCursor;
        Status("Verifying user...");
        BusinessPrincipal.Login(dlg.Username, dlg.Password);
        Status("");
        Cursor = Cursors.Default;

        if(Thread.CurrentPrincipal.Identity.IsAuthenticated)
          EnableMenus();
        else
        {
          DoLogout();
          MessageBox.Show("The username and password were not valid",
            "Failed login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      }
      else
        DoLogout();
    }

    void DoLogout()
    {
      // reset to an unauthorized principal
      Thread.CurrentPrincipal = 
        new GenericPrincipal(
        new GenericIdentity(""), new string[] {});
      //mnuAction.Enabled = False
      //mnuReport.Enabled = False
      //mnuBatch.Enabled = False
      pnlUser.Text = string.Empty;
      EnableMenus();
    }

    void EnableMenus()
    {
      IPrincipal user;
      user = Thread.CurrentPrincipal;

      pnlUser.Text = user.Identity.Name;

      //      mnuAction.Enabled = user.Identity.IsAuthenticated;
      //      mnuReport.Enabled = user.Identity.IsAuthenticated;
      //      mnuBatch.Enabled = user.Identity.IsAuthenticated;

      mnuProjectNew.Enabled = user.IsInRole("ProjectManager");

      mnuProjectRemove.Enabled = user.IsInRole("ProjectManager") || 
        user.IsInRole("Administrator");

      mnuResourceNew.Enabled = user.IsInRole("ProjectManager") || 
        user.IsInRole("Supervisor");

      mnuResourceRemove.Enabled = user.IsInRole("ProjectManager") || 
        user.IsInRole("Supervisor") ||
        user.IsInRole("Administrator");
    }

    #endregion

    #region Status

    static MainForm _main;

    public static void Status(string text)
    {
      _main.pnlStatus.Text = text;
    }

    #endregion

    #region Projects

    private void mnuProjectNew_Click(object sender, System.EventArgs e)
    {
      Cursor.Current = Cursors.WaitCursor;
      ProjectEdit frm = new ProjectEdit(Project.NewProject());
      frm.MdiParent = this;
      Cursor.Current = Cursors.Default;
      frm.Show();
    }

    private void mnuProjectEdit_Click(object sender, System.EventArgs e)
    {
      ProjectSelect dlg = new ProjectSelect("Edit Project");
      dlg.ShowDialog(this);

      string result = dlg.Result;
      if(result.Length > 0)
        try
        {
          Cursor.Current = Cursors.WaitCursor;
          Guid id = new Guid(result);
          Project obj = Project.GetProject(id);

          ProjectEdit frm = new ProjectEdit(obj);
          frm.MdiParent = this;
          Cursor.Current = Cursors.Default;
          frm.Show();
        }
        catch(Exception ex)
        {
          Cursor.Current = Cursors.Default;
          MessageBox.Show("Error loading project\n" + ex.ToString(),
            "Edit Project", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void mnuProjectRemove_Click(object sender, System.EventArgs e)
    {
      ProjectSelect dlg = new ProjectSelect("Remove Project");
      dlg.ShowDialog(this);

      string result = dlg.Result;
      if(result.Length > 0)
        if(MessageBox.Show("Remove project " + result,
                            "Remove Project",MessageBoxButtons.YesNo, 
                            MessageBoxIcon.Question) == DialogResult.Yes)
          try
          {
            Cursor.Current = Cursors.WaitCursor;
            pnlStatus.Text = "Deleting project...";

            Guid id = new Guid(result);
            Project.DeleteProject(id);

            Cursor.Current = Cursors.Default;
            MessageBox.Show("Project deleted",
              "Project Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          catch(Exception ex)
          {
            Cursor.Current = Cursors.Default;
            MessageBox.Show("Error deleting project\n" + ex.ToString(),
              "Edit Project", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
          finally
          {
            pnlStatus.Text = string.Empty;
          }
    }

    #endregion

    #region Resources

    private void mnuResourceNew_Click(object sender, System.EventArgs e)
    {
      string id = InputBox.GetInput("Resource ID", "New resource");
      if(id.Length > 0)
      {
        Cursor.Current = Cursors.WaitCursor;
        Resource obj = Resource.NewResource(id);
        ResourceEdit frm = new ResourceEdit(obj);
        frm.MdiParent = this;
        Cursor.Current = Cursors.Default;
        frm.Show();
      }
    }

    private void mnuResourceEdit_Click(object sender, System.EventArgs e)
    {
      ResourceSelect dlg = new ResourceSelect("Edit Resource");
      dlg.ShowDialog(this);

      string result = dlg.Result;
      if(result.Length > 0)
        try
        {
          Cursor.Current = Cursors.WaitCursor;
          Resource obj = Resource.GetResource(result);
          ResourceEdit frm = new ResourceEdit(obj);
          frm.MdiParent = this;
          Cursor.Current = Cursors.Default;
          frm.Show();
        }
        catch(Exception ex)
        {
          Cursor.Current = Cursors.Default;
          string msg = string.Format(
            "Error loading resource\n{0}", ex.ToString());
          MessageBox.Show(msg);
        }
    }

    private void mnuResourceRemove_Click(object sender, System.EventArgs e)
    {
      ResourceSelect dlg = new ResourceSelect("Remove Resource");
      dlg.ShowDialog(this);

      string result = dlg.Result;
      if(result.Length > 0)
      {
        if(MessageBox.Show(this, "Remove resource " + result, 
          "Remove resource", MessageBoxButtons.YesNo) == DialogResult.Yes)
          try
          {
            Cursor.Current = Cursors.WaitCursor;
            pnlStatus.Text = "Removing resource...";

            Resource.DeleteResource(result);
            Cursor.Current = Cursors.Default;
            MessageBox.Show(this, "Resource deleted");
          }
          catch(Exception ex)
          {
            Cursor.Current = Cursors.Default;
            string msg = string.Format(
              "Error deleting resource\n{0}", ex.ToString());
            MessageBox.Show(this, msg);
          }
          finally
          {
            pnlStatus.Text = string.Empty;
          }
      }
    }

    #endregion

    #region Batch

    private void mnuProjectUpdate_Click(object sender, 
      System.EventArgs e)
    {
      CSLA.BatchQueue.BatchQueue batch = 
        new CSLA.BatchQueue.BatchQueue();
      batch.Submit(new CSLA.BatchQueue.BatchJobRequest(
        "PTBatch.ProjectJob", "PTBatch"));
    }

    #endregion

    #region Reports

    private void mnuProjectList_Click(object sender, System.EventArgs e)
    {
    ProjectSelect dlg = new ProjectSelect("Project List");
    dlg.ShowDialog(this);

    string result = dlg.Result;
      if(result.Length > 0)
      {
        try
        {
          Cursor.Current = Cursors.WaitCursor;
          Guid id = new Guid(result);
          Project obj = Project.GetProject(id);

          ProjectList frm = new ProjectList();
          frm.MdiParent = this;
          frm.WindowState = FormWindowState.Maximized;
          frm.Project = obj;
          Cursor.Current = Cursors.Default;
          frm.Show();
        }
        catch(Exception ex)
        {
          Cursor.Current = Cursors.Default;
          System.Text.StringBuilder sb = new System.Text.StringBuilder();
          sb.AppendFormat("Error generating report\n");
          sb.Append(ex.ToString());
          MessageBox.Show(sb.ToString(), 
            "Reporting Error", MessageBoxButtons.OK, 
            MessageBoxIcon.Exclamation);
        }
      }
    }

    #endregion

	}
}