


Primeiro, criei uma classe chamada ImcViewModel, que é responsável por armazenar os dados informados pelo usuário, como peso e altura, além do resultado do IMC e sua classificação.

Também utilizei Data Annotations para validar os campos. Dessa forma, o sistema verifica se os valores digitados são válidos antes de realizar o cálculo.

No HomeController, criei uma ação HttpGet para exibir a página e uma ação HttpPost para receber os dados enviados pelo formulário. Quando o usuário informa o peso e a altura, o sistema calcula o IMC utilizando a fórmula:

IMC = Peso / (Altura * Altura)

Após o cálculo, o resultado é arredondado para duas casas decimais e é exibida uma classificação de acordo com o valor obtido.

Na View chamada Index, utilizei Tag Helpers para criar o formulário, os campos de entrada e as mensagens de validação. Caso o usuário informe dados incorretos, as mensagens de erro são exibidas na tela através do ModelState.

Como executar o projeto
Abrir o terminal na pasta do projeto.
Executar o comando:
dotnet build

para compilar a aplicação.

Depois executar:
dotnet run

para iniciar o projeto.

Abrir o navegador e acessar o endereço informado no terminal (normalmente http://localhost:5133).