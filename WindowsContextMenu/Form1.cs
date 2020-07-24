using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace WindowsContextMenu
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            if (!IsAdministrator()) {
                MessageBox.Show("Execute como administrador para o funcionamento do programa!", "Infuncional.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

            InitializeComponent();            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string larguraMax = nudLarguraWidth.Value.ToString();
            string alturaMax = nudLarguraWidth.Value.ToString();

            //texto a ser exibido no context
            string menuText = "Redimensionar Max: " + larguraMax + "x" + alturaMax ;

            // caminho completo da aplicacao e 3 parametros (%L parametro que retornara o path do arquivo clicado)
            string menuCommand = string.Format("\"{0}\" \"{1}\" \"{2}\" \"%L\"", Application.ExecutablePath, larguraMax, alturaMax);

            // localizacao do registro
            string regPath = string.Format(@"SystemFileAssociations\image\shell\RedimensionarImagem");

            // cria o registro e o valor do contexto
            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(regPath))
            {
                key.SetValue(null, menuText);
            }

            // adiciona o comando que sera invocado no registro
            using (RegistryKey key = Registry.ClassesRoot.CreateSubKey(string.Format(@"{0}\command", regPath)))
            {
                key.SetValue(null, menuCommand);
            }

            MessageBox.Show(regPath, "A extensão shell foi criada com Sucesso");
        }
        
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Registry.ClassesRoot.DeleteSubKeyTree(@"SystemFileAssociations\image\shell\RedimensionarImagem");
            MessageBox.Show("A extensão shell foi excluida com Sucesso", "Obrigado, Caio.");
        }

        private static bool IsAdministrator()
        {
            var identity = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
/*
    +++principais referencias+++

    https://www.it-swarm-pt.tech/pt/contextmenu/como-adicionar-item-de-menu-de-contexto-ao-windows-explorer-para-pastas/1042528840/
    https://www.howtogeek.com/107965/how-to-add-any-application-shortcut-to-windows-explorers-context-menu/
    https://www.iperiusbackup.net/pt-br/aprendendo-no-windows-a-adicionar-aplicativos-ao-menu-de-contexto/
    https://superuser.com/questions/136838/which-special-variables-are-available-when-writing-a-shell-command-for-a-context
    https://www.codeproject.com/Articles/10104/Add-a-context-menu-to-the-Windows-Explorer
    https://www.codeproject.com/Articles/15171/Simple-shell-context-menu
    https://stackoverflow.com/questions/39827324/can-i-edit-the-context-menu-of-a-text-field-not-explorer-context-menu     
*/
