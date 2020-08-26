namespace TelevisaoCet30GUI
{
    using System;
    using System.IO;

    public class Tv
    {
        #region atributos 
        
        private bool estado;
        private int canal;
        private readonly string mensagem;
        private int volume;

        #endregion
        
        #region propriedades
        
        public bool Estado
        {
            get{ return estado; }
            set{ estado = false; }

        }
       
        public int Volume { get; set; }

        public int Canal
        {
            get { return canal; }
            set
            {
                if (value > 0 && value <= 20)
                    canal = value;
            }
        }

        public string Mensagem { get; private set; }

        #endregion
       

        #region Construtores
        //todos estes métodos obrigatórios: default, construtor e cópia

          /// <summary>
          /// Construtor default
          /// </summary>
        public Tv()
        {
            estado = false;
            canal = 1;
            volume = 25;
            mensagem = "Nova tv criada com sucesso!";
        }

          /// <summary>
          /// Construtor por parâmetros
          /// </summary>
        public Tv(int canal, int volume)
        {
            Estado = false;
            Canal = canal;
            Volume = volume;
            Mensagem = "Nova tv criada com sucesso!";
        }

        /// <summary>
        /// Construtor cópia
        /// </summary>
        public Tv(Tv televisao)
        {
            Canal = televisao.Canal;
            Volume = televisao.Volume;
            Estado = televisao.Estado;
            Mensagem= "Nova tv criada com sucesso!";
        }

        #endregion

        #region Métodos

        public void LigaTv()
        {
            if (!estado)
            {
                estado = true;
                LerInfo();
                Mensagem = "TV Ligada!";
            }
        }

        public void DesligaTv()
        {
            if (estado)
            {
                estado = false;
                GravarInfo();
                Mensagem = "TV Desligada!";
            }
        }
        public void AumentaVolume(int valor)
        {
            Volume += valor;
        }

        public void DiminuiVolume(int valor)
        {
            Volume -= valor;
        }

        private void GravarInfo()
        {
            string ficheiro = @"tvInfo.txt";

            string linha = Canal + ";" + Volume;

            StreamWriter sw = new StreamWriter(ficheiro, false);

            if (!File.Exists(ficheiro))
            {
                sw = File.CreateText(ficheiro);
            }

            sw.WriteLine(linha);
            sw.Close();
        }

        private void LerInfo()
        {
            string ficheiro = @"tvInfo.txt";

            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);

                string linha = "";

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = new string[2];

                    campos = linha.Split(';');

                    canal = Convert.ToInt32(campos[0]);
                    volume = Convert.ToInt32(campos[1]);
                }
                sr.Close();
            }
        }

        #endregion
    }
}



