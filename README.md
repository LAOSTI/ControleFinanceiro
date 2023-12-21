OBS.: Este projeto ainda precisa passar por melhorias significativas que foram aprendidas após a conclusão inicial. Ainda falta implementar atualização de dados e exclusão de dados que persiste na tela de período.
<h1> Controle Financeiro em C# e windows forms </h1>
Status: Irei atualizar todo projeto utilizando conceito de POO em breve. 🛠️
<br></br>
Desenvolvi este projeto no início dos meus estudos com o objetivo de criar um relatório mais estavel e completo para o meu controle financeiro, buscando assim me libertar do uso constante de planilhas no Excel.
<h2>Estrutura do Projeto</h2>
O sistema é composto por três funções principais:

<h3>Registro de dividas</h3>
<ul>
  <li>Permite a adição de um pagamento ou divida realizada.</li>
</ul>
<h3>Registro de entrada</h3>
<ul>
  <li>Permite a adição de uma entrada como pagamento, serviço de renda extra entre outros.</li>
</ul>
<h3>Consulta por período</h3>
<ul>
  <li>Permite realizar consulta dos dados registrados em dividas e entradas.</li>
</ul>
<h2>Instalação e Configuração</h2>
Siga os passos abaixo para configurar o projeto em sua máquina local:
<h3>Clonar o Repositório</h3>
  git clone https://github.com/LAOSTI/ControleFinanceiro.git
<h3>Configurar o Banco de Dados</h3>
  <ul>
    <li>Crie um banco de dados com o nome "controlefinanceiro".</li>
    <li>Crie uma tabela com o nome de divida contendo como coluna(ID,CATEGORIA,DESCRICAO,VALOR,DTREGISTRO)</li>
    <li>Crie uma tabela com o nome de entrada contendo como coluna(ID,CATEGORIA,DESCRICAO,VALOR,DTREGISTRO)</li>
  </ul>
<h3>Configurar Visual Studio 2022</h3>
  <ul>
    <li>Execute o Visual Studio 2022</li>
  </ul>
<h2>Uso</h3>
  <ul>
    <li>Execute o WampServer</li>
    <li>Execute a aplicação</li>
  </ul>
