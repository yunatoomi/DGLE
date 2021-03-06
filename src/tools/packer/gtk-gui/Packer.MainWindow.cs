
// This file has been generated by the GUI designer. Do not modify.
namespace Packer
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;
		private global::Gtk.Action FileAction;
		private global::Gtk.Action CloseAction;
		private global::Gtk.Action HelpAction;
		private global::Gtk.Action AboutAction;
		private global::Gtk.Action OpenAction;
		private global::Gtk.Action SaveAction;
		private global::Gtk.Action NewAction;
		private global::Gtk.Action PackAction;
		private global::Gtk.Action AddFilesAction;
		private global::Gtk.Action RemoveAction;
		private global::Gtk.Action ExtractAction;
		private global::Gtk.Action ExtractAllAction;
		private global::Gtk.Action AddFolderAction;
		private global::Gtk.Action ExitAction;
		private global::Gtk.Action CreateFolderAction;
		private global::Gtk.Action SupportedFormatsAction;
		private global::Gtk.Action TestAction;
		private global::Gtk.VBox vbox1;
		private global::Gtk.MenuBar mainMenuBar;
		private global::Gtk.VBox vbox2;
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		private global::Gtk.TreeView packTreeView;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Packer.MainWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
			this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
			w1.Add (this.FileAction, null);
			this.CloseAction = new global::Gtk.Action ("CloseAction", global::Mono.Unix.Catalog.GetString ("Close"), null, "package-delete");
			this.CloseAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Close");
			w1.Add (this.CloseAction, "<Control>q");
			this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
			this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
			w1.Add (this.HelpAction, null);
			this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, "information");
			this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
			w1.Add (this.AboutAction, null);
			this.OpenAction = new global::Gtk.Action ("OpenAction", global::Mono.Unix.Catalog.GetString ("Open"), null, "folder");
			this.OpenAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open");
			w1.Add (this.OpenAction, "F2");
			this.SaveAction = new global::Gtk.Action ("SaveAction", global::Mono.Unix.Catalog.GetString ("Save"), null, "disk");
			this.SaveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Save");
			w1.Add (this.SaveAction, "F3");
			this.NewAction = new global::Gtk.Action ("NewAction", global::Mono.Unix.Catalog.GetString ("New"), null, "package");
			this.NewAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("New");
			w1.Add (this.NewAction, null);
			this.PackAction = new global::Gtk.Action ("PackAction", global::Mono.Unix.Catalog.GetString ("Pack"), null, null);
			this.PackAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Pack");
			w1.Add (this.PackAction, null);
			this.AddFilesAction = new global::Gtk.Action ("AddFilesAction", global::Mono.Unix.Catalog.GetString ("Add Files..."), null, "page-white-add");
			this.AddFilesAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Add Files...");
			w1.Add (this.AddFilesAction, "F4");
			this.RemoveAction = new global::Gtk.Action ("RemoveAction", global::Mono.Unix.Catalog.GetString ("Remove"), null, "page-white-delete");
			this.RemoveAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Remove");
			w1.Add (this.RemoveAction, "F8");
			this.ExtractAction = new global::Gtk.Action ("ExtractAction", global::Mono.Unix.Catalog.GetString ("Extract..."), null, "page-white-copy");
			this.ExtractAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Extract...");
			w1.Add (this.ExtractAction, "F5");
			this.ExtractAllAction = new global::Gtk.Action ("ExtractAllAction", global::Mono.Unix.Catalog.GetString ("Extract all..."), null, "page-white-stack");
			this.ExtractAllAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Extract all...");
			w1.Add (this.ExtractAllAction, "<Shift>F5");
			this.AddFolderAction = new global::Gtk.Action ("AddFolderAction", global::Mono.Unix.Catalog.GetString ("Add Folder..."), null, "folder-add");
			this.AddFolderAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Add Folder...");
			w1.Add (this.AddFolderAction, "<Shift>F4");
			this.ExitAction = new global::Gtk.Action ("ExitAction", global::Mono.Unix.Catalog.GetString ("Exit"), null, "door_open");
			this.ExitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Exit");
			w1.Add (this.ExitAction, null);
			this.CreateFolderAction = new global::Gtk.Action ("CreateFolderAction", global::Mono.Unix.Catalog.GetString ("Create Folder"), null, null);
			this.CreateFolderAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Create Folder");
			w1.Add (this.CreateFolderAction, null);
			this.SupportedFormatsAction = new global::Gtk.Action ("SupportedFormatsAction", global::Mono.Unix.Catalog.GetString ("Supported formats"), null, "book_open");
			this.SupportedFormatsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Supported formats");
			w1.Add (this.SupportedFormatsAction, null);
			this.TestAction = new global::Gtk.Action ("TestAction", global::Mono.Unix.Catalog.GetString ("Test"), null, null);
			this.TestAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Test");
			w1.Add (this.TestAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "Packer.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Packer");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Decorated = false;
			// Container child Packer.MainWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString (@"<ui><menubar name='mainMenuBar'><menu name='FileAction' action='FileAction'><menuitem name='NewAction' action='NewAction'/><menuitem name='OpenAction' action='OpenAction'/><menuitem name='SaveAction' action='SaveAction'/><menuitem name='CloseAction' action='CloseAction'/><menuitem name='ExitAction' action='ExitAction'/></menu><menu name='PackAction' action='PackAction'><menuitem name='AddFilesAction' action='AddFilesAction'/><menuitem name='AddFolderAction' action='AddFolderAction'/><menuitem name='RemoveAction' action='RemoveAction'/><menuitem name='ExtractAction' action='ExtractAction'/><menuitem name='ExtractAllAction' action='ExtractAllAction'/></menu><menu name='HelpAction' action='HelpAction'><menuitem name='SupportedFormatsAction' action='SupportedFormatsAction'/><menuitem name='AboutAction' action='AboutAction'/></menu></menubar></ui>");
			this.mainMenuBar = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/mainMenuBar")));
			this.mainMenuBar.Name = "mainMenuBar";
			this.vbox1.Add (this.mainMenuBar);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.mainMenuBar]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			this.vbox2.BorderWidth = ((uint)(6));
			// Container child vbox2.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.packTreeView = new global::Gtk.TreeView ();
			this.packTreeView.CanFocus = true;
			this.packTreeView.Name = "packTreeView";
			this.GtkScrolledWindow.Add (this.packTreeView);
			this.vbox2.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.GtkScrolledWindow]));
			w4.Position = 0;
			this.vbox1.Add (this.vbox2);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.vbox2]));
			w5.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 522;
			this.DefaultHeight = 400;
			this.Show ();
		}
	}
}
