# Projeto Jogo Sequência

Este projeto é um jogo simples de sequência de cores desenvolvido em C# utilizando Windows Forms.

## Descrição

O Jogo Sequência é uma implementação do clássico jogo de memória onde o jogador precisa repetir uma sequência de cores apresentada pelo computador.

## Dependências

  - Linguagem C#
  - .NET Core 7.
  - Visual Studio 2022 para desenvolvimento.

## Instalação

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/Projeto_Jogo_Sequencia.git
   
2. Abra o arquivo de solução JogoSequencia.sln no Visual Studio.

3. Clique com o botão direito na pasta Som, selecione a opção Copy Full Path e cole entre as aspas para adicionar o valor ao caminhoSom. 

4. Compile o projeto e execute a aplicação.

## Estrutura do Projeto

### O projeto está estruturado da seguinte forma:

    - MainForm.cs: Contém a lógica principal do jogo, incluindo a geração de sequências, manipulação de eventos de botões e verificação de respostas do jogador.
    - Som/: Pasta que contém os arquivos de som utilizados pelo jogo.
    - GameOverForm.cs: Formulário de tela de game over exibido quando o jogador comete um erro.

## Componentes Principais
### MainForm

- A classe MainForm representa a janela principal do jogo onde ocorre a interação com o usuário.
### Campos

    - private string caminhoSom: Caminho base para os arquivos de som.
    - private List<int> sequenciaJogo: Lista que armazena a sequência gerada pelo jogo.
    - private List<int> sequenciaUsuario: Lista que armazena a sequência inserida pelo jogador.
    - private bool iniciou: Indica se o jogo foi iniciado.
    - private int nivel: Nível atual do jogo.
    - private SoundPlayer som: Objeto para reprodução de sons.

### Métodos Principais

    - MainForm(): Construtor da classe.
    - btnIniciar_Click(object sender, EventArgs e): Evento de clique no botão iniciar jogo.
    - btnVermelho_Click(object sender, EventArgs e), btnVerde_Click(object sender, EventArgs e), btnAzul_Click(object sender, EventArgs e), btnAmarelo_Click(object sender, EventArgs e): Eventos de clique nos botões de cores.
    - GerarSequencia(): Gera uma nova sequência de cores.
    - MostrarSequencia(): Mostra a sequência gerada visualmente.
    - PiscarBotao(int botao): Realiza o efeito de "piscar" nos botões de cor.
    - ChecarResposta(int posicaoAtual): Verifica se a sequência do jogador está correta.

### Arquivos de Som

    - Os arquivos de som (red.wav, green.wav, blue.wav, yellow.wav, correct.wav, wrong.wav) localizam-se na pasta Som/ dentro do diretório especificado em caminhoSom.

## Funcionalidades

- Geração aleatória de sequências de cores.
- Interface gráfica com botões coloridos para o jogador interagir.
- Sons para feedback durante o jogo.


## Uso

    - Clique no botão "Iniciar" para começar o jogo.
    - Repita a sequência de cores exibida clicando nos botões correspondentes.
    - O jogo termina quando o jogador erra a sequência.

## Contribuição

### Sinta-se à vontade para contribuir com melhorias. Para isso, siga os passos:

    - Fork o repositório.
    - Crie uma branch com a sua feature (git checkout -b feature/MinhaFeature).
    - Commit suas mudanças (git commit -am 'Adiciona nova feature').
    - Push para a branch (git push origin feature/MinhaFeature).
    - Crie um novo Pull Request.
    
## Direitos Autorais e Licença

© 2024 Wellington Cerqueira Araujo

- Este projeto utiliza sons obtidos do site Pixabay (https://pixabay.com), que estão disponíveis para uso livre conforme os termos de uso do site.
- Consulte o arquivo LICENSE para mais detalhes sobre a licença do código-fonte deste projeto.
