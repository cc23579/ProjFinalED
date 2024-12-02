using apCaminhosEmMarte;
using Arvores2024;
using System.IO;
using System.Windows.Forms;


namespace CaminhoEntreCidades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LerArquivoDeRegistros("CidadesMarte.dat");
            PreencherCombo(cbxOrigem);
            PreencherCombo(cbxDestino);
        }

        
        // Inicializa a árvore de cidades e a lista de caminhos
        Arvore<Cidade> arvoreBinaria = new Arvore<Cidade>(); 
        ListaSimples<CaminhoEntreCidadesMarte> listaCaminhos = new ListaSimples<CaminhoEntreCidadesMarte>(); 
        
        public void LerArquivoDeRegistros(string nomeArquivoCidades)
        {
            // Abre o arquivo de cidades e lê os registros
            using (var origemCidades = new System.IO.FileStream(nomeArquivoCidades, FileMode.OpenOrCreate))
            using (var arquivoCidades = new BinaryReader(origemCidades))
            {
                LerCidadesECaminhosRecursivo(arquivoCidades, 0, arvoreBinaria, listaCaminhos);
            }

        }

        // Método para ler as cidades e associar os caminhos à medida que lê os registros
        // Método para ler as cidades e associar os caminhos à medida que lê os registros
        public static void LerCidadesECaminhosRecursivo(BinaryReader arquivo, long qualRegistro, Arvore<Cidade> arvoreBinaria, ListaSimples<CaminhoEntreCidadesMarte> listaCaminhos)
        {
            if (arquivo.BaseStream.Position < arquivo.BaseStream.Length)
            {
                Cidade cidade = new Cidade();
                cidade.LerRegistro(arquivo, qualRegistro);

                // Cria uma lista de caminhos vazia para a cidade
                cidade.Caminhos = new ListaSimples<CaminhoEntreCidadesMarte>();

                arvoreBinaria.IncluirNovoRegistro(cidade);

                // Lê os caminhos e os associa à cidade de origem
                using (var origemCaminhos = new System.IO.FileStream("CaminhoEntreCidadesMarte.dat", FileMode.OpenOrCreate))
                using (var arquivoCaminhos = new BinaryReader(origemCaminhos))
                {
                    LerCaminhosRecursivo(arquivoCaminhos, qualRegistro, cidade, listaCaminhos);
                }

                // Chama a recursão para o próximo registro (próxima cidade)
                LerCidadesECaminhosRecursivo(arquivo, qualRegistro + 1, arvoreBinaria, listaCaminhos);
            }
        }

        // Método para associar os caminhos às cidades
        private static void LerCaminhosRecursivo(BinaryReader arquivo, long qualRegistro, Cidade cidade, ListaSimples<CaminhoEntreCidadesMarte> listaCaminhos)
        {
            if (arquivo.BaseStream.Position < arquivo.BaseStream.Length)
            {
                CaminhoEntreCidadesMarte caminho = new CaminhoEntreCidadesMarte();
                caminho.LerRegistro(arquivo, qualRegistro);

                if (caminho.CidadeOrigem == cidade.NomeCidade)
                {
                    // Se a cidade de origem for a mesma, adiciona o caminho à lista de caminhos dessa cidade
                    cidade.Caminhos.InserirAposFim(caminho);
                }

                // Chama recursivamente para o próximo caminho
                LerCaminhosRecursivo(arquivo, qualRegistro + 1, cidade, listaCaminhos);
            }
        }

        public void PreencherCombo(NoArvore<Cidade> atual, ComboBox comboBox)
        {
            if (atual != null)
            {
                
                PreencherCombo(atual.Esq, comboBox);

                comboBox.Items.Add(atual.Info);

                
                PreencherCombo(atual.Dir, comboBox);
            }
        }

    }
}
