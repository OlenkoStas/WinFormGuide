using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;

namespace Guide
{

    public partial class Form1 : Form
    {
        FileSystemWatcher _watcher = new FileSystemWatcher();
        /// <summary>
        /// Список посещаемых каталогов(для возврата назад)
        /// </summary>
        List<string> _navigatePathList = new List<string>();
        public Form1()
        {
            InitializeComponent();
            InitcbDrive();
            InitImageList();
            InitcbListViewStyle();
            _watcher.Created += WatcherCreate;
            _watcher.Deleted += WatcherDeleted;
            listView.FullRowSelect = true;
        }
        /// <summary>
        /// Выдает сообщение при удалении из текущей папки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WatcherDeleted(object sender, FileSystemEventArgs e)
        {
            string msg = "Удаление файла или каталога!";
            MessageBox.Show(msg, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Выдает сообщение при создании папки в текущем каталоге
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WatcherCreate(object sender, FileSystemEventArgs e)
        {
            string msg = "Создание каталога!";
            MessageBox.Show(msg, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Подключает FileSystemWatcher к текущему каталогу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbFullPath_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _navigatePathList.Add(tbCurrentFullPath.Text);
                _watcher.Path = tbCurrentFullPath.Text;
                _watcher.EnableRaisingEvents = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Инициализирует список стилей отображения элементов в ListView
        /// </summary>
        private void InitcbListViewStyle()
        {
            cbListViewStyle.Items.AddRange(Enum.GetNames(typeof(View)));
            cbListViewStyle.SelectedIndex = 0;
        }

        /// <summary>
        /// Инициализирует список доступных дисков на пк
        /// </summary>
        private void InitcbDrive()
        {
            cbDrives.Items.AddRange(Environment.GetLogicalDrives());
            cbDrives.SelectedIndex = 0;
            //сразу отображает элементы текущего логического диска
            ShowListViewContent(cbDrives.SelectedItem as string);
        }
        /// <summary>
        /// Проверка на наличие новых устройств в системе(флешка)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDrives_DropDown(object sender, EventArgs e)
        {
            if (cbDrives.Items.Count != Environment.GetLogicalDrives().Count())
            {
                cbDrives.Items.Clear();
                cbDrives.Items.AddRange(Environment.GetLogicalDrives());
            }
        }
        /// <summary>
        /// Изменяет текущий логический диск
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDrives.SelectedIndex != -1)
            {
                InitTree(cbDrives.SelectedItem as string);
            }
        }

        /// <summary>
        /// Инициализирует список картинок для TreeView и ListView
        /// </summary>
        private void InitImageList()
        {
            ImageList imageList = new ImageList();
            imageList.Images.Add(Image.FromFile("Images/FolderClosed.png"));
            imageList.Images.Add(Image.FromFile("Images/FolderOpen.png"));
            imageList.Images.Add(Image.FromFile("Images/File.png"));
            imageList.ImageSize = new Size(24, 24);

            ImageList largeList = new ImageList();
            largeList.Images.Add(Image.FromFile("Images/FolderClosed.png"));
            largeList.Images.Add(Image.FromFile("Images/FolderOpen.png"));
            largeList.Images.Add(Image.FromFile("Images/File.png"));
            largeList.ImageSize = new Size(36, 36);
            //для ListView
            listView.SmallImageList = imageList;
            listView.LargeImageList = largeList;
            //для TreeView
            treeView.ImageList = imageList;
        }
        /// <summary>
        /// Начальная инициализация дерева
        /// </summary>
        /// <param name="path"></param>
        private void InitTree(string path)
        {
            treeView.Nodes.Clear();
            if (Directory.Exists(path))
            {
                foreach (var dir in Directory.GetDirectories(path))
                {
                    DirectoryInfo di = new DirectoryInfo(dir);
                    TreeNode node = new TreeNode(di.Name, 0, 1);
                    node.Nodes.Add("");
                    node.Tag = di.FullName;
                    treeView.Nodes.Add(node);
                }
            }
        }
        /// <summary>
        /// Заполняет выбраный узел элементами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            treeView.SelectedNode = e.Node;
            //Отображает на экране текущий путь
            tbCurrentFullPath.Text = e.Node.Tag.ToString();
            string path = e.Node.Tag.ToString();

            e.Node.Nodes.Clear();
            try
            {
                foreach (var dir in Directory.GetDirectories(path))
                {
                    DirectoryInfo di = new DirectoryInfo(dir);
                    TreeNode node = new TreeNode(di.Name, 0, 0);
                    node.Nodes.Add("");
                    node.Tag = di.FullName;
                    e.Node.Nodes.Add(node);
                }
            }
            catch (Exception)
            {
                //Отказано в доступе к каталогу 
            }
        }
        /// <summary>
        /// Изменение стиля отображения в ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbListViewStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbListViewStyle.SelectedIndex != -1)
            {
                string style = cbListViewStyle.SelectedItem as string;
                listView.View = (View)Enum.Parse(typeof(View), style);
            }
        }
        /// <summary>
        /// По клику по узлу - отображает элементы в ListView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            ShowListViewContent(e.Node.Tag.ToString());
            string path = e.Node.Tag.ToString();
            if (Directory.Exists(path))
            {
                try
                {
                    pbIcon.ImageLocation = @"Images\FolderClosed.png";
                    lblType.Text = $"Элементов : {Directory.GetDirectories(path).Count() + Directory.GetFiles(path).Count()}";
                }
                catch(Exception)
                {
                    //Нет прав доступа к каталогу
                }
            }
        }
        /// <summary>
        /// Отображает все элементы текущего каталога
        /// </summary>
        /// <param name="path">Путь к каталогу или файлу</param>
        private void ShowListViewContent(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    tbCurrentFullPath.Text = path;
                    listView.Clear();
                    listView.Columns.Add(new ColumnHeader { Text = "Name", Width = 150 });
                    listView.Columns.Add(new ColumnHeader { Text = "Type" });
                    listView.Columns.Add(new ColumnHeader { Text = "Size" });
                    foreach (var dir in Directory.GetDirectories(path))
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        ListViewItem lv = new ListViewItem(di.Name, 0);
                        lv.Tag = di.FullName;
                        lv.SubItems.Add(new ListViewItem.ListViewSubItem(lv, "Папка"));
                        listView.Items.Add(lv);
                    }
                    foreach (var dir in Directory.GetFiles(path))
                    {
                        FileInfo fi = new FileInfo(dir);
                        ListViewItem lv = new ListViewItem(fi.Name, 2);
                        lv.Tag = fi.FullName;
                        lv.SubItems.Add(new ListViewItem.ListViewSubItem(lv, "Файл"));
                        lv.SubItems.Add(new ListViewItem.ListViewSubItem(lv, (fi.Length / 1000).ToString() + " КБ"));
                        listView.Items.Add(lv);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //каталог недоступен
            }
        }
        /// <summary>
        /// Переход к дочернему элементу или запуск файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView senderList = (ListView)sender;
            ListViewItem clickedItem = senderList.HitTest(e.Location).Item;
            if (clickedItem != null && File.Exists(clickedItem.Tag.ToString()))
            {
                Process.Start(clickedItem.Tag.ToString());
            }
            else if (clickedItem != null)
            {
                tbCurrentFullPath.Text = clickedItem.Tag.ToString();
                ShowListViewContent(clickedItem.Tag.ToString());
            }
        }
        /// <summary>
        /// Изменяет отображаемый текущий путь на перед закрытием узла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            tbCurrentFullPath.Text = e.Node.Tag.ToString();
        }
        /// <summary>
        /// Возвращает на предыдущий уровень
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (_navigatePathList.Count != 0 && _navigatePathList.Count != 1)
            {
                _navigatePathList.RemoveAt(_navigatePathList.Count - 1);
                tbCurrentFullPath.Text = _navigatePathList.Last();
                ShowListViewContent(tbCurrentFullPath.Text);
                _navigatePathList.RemoveAt(_navigatePathList.Count - 1);
            }
        }
        /// <summary>
        /// Показывает дополнительную информацию об элементе в низу окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = listView.SelectedItems;
            if (item.Count == 1)
            {
                string path = item[0].Tag.ToString();
                if (Directory.Exists(path))
                {
                    DirectoryInfo info = new DirectoryInfo(path);
                    pbIcon.ImageLocation = @"Images\FolderOpen.png";
                    lblType.Text = $"{info.Name}\nПапка с файлами";
                    lblDate.Text = $"Дата создания\n{info.CreationTime}";
                    lblSize.Text = "";
                }
                else if (File.Exists(path))
                {
                    FileInfo info = new FileInfo(path);
                    pbIcon.ImageLocation = @"Images\File.png";
                    lblType.Text = $"{info.Name}\nФайл";
                    lblDate.Text = $"Дата создания\n{info.CreationTime}";
                    lblSize.Text = $"Размер \n{info.Length / 1000} КБ";
                }
            }
        }
    }
}
