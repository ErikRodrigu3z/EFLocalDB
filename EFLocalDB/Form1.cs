using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using EFLocalDB.Models;

namespace EFLocalDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopGridView();
            PopGridView2();
        }

        private void PopGridView()
        {
            using (var MyModelEntities = new MyDBContext())
            {
                dataGridView1.DataSource = MyModelEntities.usuariosDB.ToList<Usuarios>();
            }
        }

        private void PopGridView2()
        {
            using (var MyModelEntities = new MyDBContext())
            {
                dataGridView2.DataSource = MyModelEntities.AspNetRolesDB.ToList<AspNetRoles>();
            }
        }

    }
}
