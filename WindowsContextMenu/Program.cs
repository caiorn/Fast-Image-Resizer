using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace WindowsContextMenu
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                //se clicou no contexto (se houver parametros) executar a acao reduzir a imagem.
                if (args.Length != 0)
                {
                    //captura os argumentos
                    int largura = int.Parse(args[0]);
                    int altura = int.Parse(args[1]);
                    string filePath = args[2];


                    Image img = Image.FromFile(filePath);
                    img = ScaleImage(img, largura, altura);

                    //adiciono a resolução ao nome das novas imagens
                    string caminhoEimagemRenomeada = Path.Combine(
                        Path.GetDirectoryName(filePath),
                        string.Format("{0} ({1}x{2}){3}",
                            Path.GetFileNameWithoutExtension(filePath),
                            img.Height,
                            img.Width,
                            Path.GetExtension(filePath)));

                    img.Save(caminhoEimagemRenomeada, ImageFormat.Jpeg);
                }
                //senao abre a interface para configuração
                else
                {                
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Form1());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                throw;
            }
            
        }

        /// <summary>
        /// Escala o tamanho da Imagem proporcionalmente para o tamanho maximo definido na largura(width) ou altura
        /// </summary>
        /// <param name="image">Imagem a modificar o tamanho</param>
        /// <param name="maxWidth">tamanho maximo da largura que ela poderá ter</param>
        /// <param name="maxHeight">tamanho maximo da altura que ela poderá ter</param>
        /// <returns>Image com novo tamanho</returns>
        private static Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {            
            if (image.Width > 200 || image.Height > 400)
            {

                var ratioX = (double)maxWidth / image.Width;
                var ratioY = (double)maxHeight / image.Height;
                var ratio = Math.Min(ratioX, ratioY);

                var newWidth = (int)(image.Width * ratio);
                var newHeight = (int)(image.Height * ratio);

                var newImage = new Bitmap(newWidth, newHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                using (var graphics = Graphics.FromImage(newImage))
                    graphics.DrawImage(image, 0, 0, newWidth, newHeight);

                return newImage;
            }
            else {
                return image;
            }            
        }
    }
}
