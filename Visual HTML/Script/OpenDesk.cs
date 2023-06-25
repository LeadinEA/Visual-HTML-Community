using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_HTML.Script
{
    internal class OpenDesk
    {
        public void ShowTreeView(TreeView treeview, string path)
        {
            try
            {
                treeview.Nodes.Clear();//清空所有
                TreeNode rootNode = new TreeNode(path);//载入显示
                rootNode.Tag = path;//树节点数据
                rootNode.Text = path;//节点标签显示内容
                treeview.Nodes.Add(rootNode);//添加根目录

                DirectoryInfo dirs = new DirectoryInfo(path);//创建目录对象
                DirectoryInfo[] dir = dirs.GetDirectories();//目录下的所有子目录
                int dirCount = dir.Count();//子目录个数
                for (int i = 0; i < dirCount; i++)
                {
                    rootNode.Nodes.Add(dir[i].Name);//在根节点下添加子节点（dir[i].Name目录名称）
                    string pathNode = path + "\\" + dir[i].Name;//子节点的全路径
                    //foreach (FileInfo file in dirs.GetFiles("*.*", SearchOption.AllDirectories))
                    //{
                    //    //treeNode.Nodes.Add(file.Name);
                    //    rootNode.Nodes[i].Nodes.Add(file.Name);
                    //    //rootNode.Nodes.Add(file.Name);
                    //}
                    GetNode(rootNode.Nodes[i], pathNode);//遍历目录下的子目录
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n出错位置");
            }

        }


        private bool GetNode(TreeNode treeNode, string path)
        {
            //TreeNode rootNode = new TreeNode();

            if (Directory.Exists(path) == false)
            {
                return false;
            }
            DirectoryInfo dirs = new DirectoryInfo(path);
            DirectoryInfo[] dir = dirs.GetDirectories();
            int dirCount = dir.Count();
            if (dirCount == 0)
            {
                return false;
            }
            //for (int i = 0; i < dirCount; i++)
            //{
            //   // treeNode.Nodes.Add(rootNode);
            //    treeNode.Nodes.Add(dir[i].Name);
            //    //treeNode.Nodes[dir[i].Name].Nodes.Add(rootNode);
            //    string pathNode = path + "\\" + dir[i].Name;
            //    foreach (FileInfo file in dirs.GetFiles("*.*", SearchOption.AllDirectories))
            //    {
            //        rootNode.Nodes.Add(file.Name);
            //        //treeNode.Nodes[i].Nodes.Add(rootNode);
            //    }
            //    GetNode(treeNode.Nodes[i], pathNode);//递归遍历目录下的子目录
            //}
            for (int i = 0; i < dirCount; i++)
            {
                treeNode.Nodes.Add(dir[i].Name);
                string pathNode = path + "\\" + dir[i].Name;
                foreach (FileInfo file in dirs.GetFiles("*.*", SearchOption.AllDirectories))
                {
                    //treeNode.Nodes.Add(file.Name);
                    treeNode.Nodes[i].Nodes.Add(file.Name);
                    //rootNode.Nodes.Add(file.Name);
                }
                GetNode(treeNode.Nodes[i], pathNode);
            }
            return true;
        }
    }
}
