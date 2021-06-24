# ProjetoEngenhariaSoftware

#Elementos do grupo: João David Nóbrega nº 2087318
#Francisco Vasconcelos nº 2044718 
#Tiago Velosa nº 2046318

Neste trabalho criamos uma aplicação para apoiar a pescrição de medicamentos,tratamentos e exercícios físicos. A principal motivação é a desmaterialização deste tipo de processos e garantir um crontrolo mais eficas do cumprimento da terapia pescrita.

Para tal criamos uma página de autenticação que permite um utilizar normal, ou seja um cliente, efetuar login se já estiver registado no sistema se isso não acontecer temos a opção de criar um utilizador cliente novo.
Esta página de autenticação também é utilizada por outros membros da clínica como os doutores, secretárias/secreterários e o administrador.
Para criar novos doutores precisamos de ser administrador.
Contas especiais: admin e secretary, a conta admin serve para o administrador e permite criar contas, a conta secretary serve para marcar sessões de terapias para sessões de tratamento.
username : admin
password : admin
username : secretary
password : secretary

![image](https://user-images.githubusercontent.com/49655530/123288352-66232a00-d507-11eb-92a5-e7c69dc5b1c4.png)


No Register é possível criar um utilizador novo preenchendo os campos todos, tendo em conta as restrições como o username tem de ser único, a password igual nos dois campos, o nome não pode ter números, o número de telefone tem de ter 9 dígitos, começar em 9 e só ter números e a data de nascimento só aceita utilizadores com 18 anos.

![image](https://user-images.githubusercontent.com/49655530/123289385-56581580-d508-11eb-8083-e066ed95403c.png)

O register também possui um botão de reset para apagar o conteúdo de todos os campos.

Para a criação de um doutor temos de aceder ao menu do administrador.

![image](https://user-images.githubusercontent.com/49655530/123289851-b5b62580-d508-11eb-8359-4cff8a0972e3.png)

O registo do doutor é semelhante ao do cliente e possui as mesmas validações com a adição do campo do salário que só pode possuir números.

![image](https://user-images.githubusercontent.com/49655530/123290153-f3b34980-d508-11eb-9e31-066f25aa10ae.png)

O dashboard do doctor é apresentado com as seguintes opções 

![image](https://user-images.githubusercontent.com/49655530/123290517-4260e380-d509-11eb-9cd6-611c4e55b268.png)

A opção de criar prescrições apresenta o seguinte:

![image](https://user-images.githubusercontent.com/49655530/123290678-6290a280-d509-11eb-82b5-f064a14a840e.png)


A opção editar pescrições apresenta o seguinte:

![image](https://user-images.githubusercontent.com/49655530/123290798-789e6300-d509-11eb-9b7f-f43a9e2d79b8.png)


Selecionando uma prescrição obtemos as seguintes opções onde para editar qualquer parte da prescrição temos de selecionar o elemento, editar as caixas de texto que carregam a informação do elemento selecionado e depois clicar no botão editar respetivo, no final das edições é preciso clicar editar prescrição para editar o conteúdo que foi alterado na prescrição:

![image](https://user-images.githubusercontent.com/49655530/123290979-9b307c00-d509-11eb-9ddc-1eeb8196dec3.png)

A sessão de terapia apresenta o seguinte quando selecionado uma sessão de terapia:

![image](https://user-images.githubusercontent.com/49655530/123292504-029afb80-d50b-11eb-9976-65026d03d6c3.png)

É possível acabar a sessão selecionando, onde é apresentado uma janela que pede para escrevermos uma nota sobre o acabamento da sessão:

![image](https://user-images.githubusercontent.com/49655530/123292704-38d87b00-d50b-11eb-827f-bfa555af1185.png)

A opção de consultar prescrições apresenta as prescrições de outros doutores que foram tornadas públicas pelos utilizadores:

![image](https://user-images.githubusercontent.com/49655530/123294504-d08a9900-d50c-11eb-8c8d-e275b26b3927.png)


A imagem seguinte é o botão de logout e está presente em vários dashboards:

![image](https://user-images.githubusercontent.com/49655530/123294616-eb5d0d80-d50c-11eb-858f-46d4df71df6e.png)



A conta secretary possui o seguinte e vai carregando os outros elementos sempre que for selecionado a opção e carregar o elemento:

![image](https://user-images.githubusercontent.com/49655530/123291476-0c702f00-d50a-11eb-98b2-cd9488c5498d.png)

Ao selecionar o cliente, carregar a prescrição, selecionar a prescrição e carregar os tratamentos obtemos o seguinte:

![image](https://user-images.githubusercontent.com/49655530/123292382-e8f9b400-d50a-11eb-99b3-78fe4032032c.png)

O dashboard do client é o seguinte:

![image](https://user-images.githubusercontent.com/49655530/123293510-f4011400-d50b-11eb-8e7c-ec0f8fe8cd29.png)


A opção consultar prescrições apresenta as prescrições e quando a prescrição selecionado é carregada apresenta a informação dos medicamentos, exercícios e tratamentos relacionados com essa prescrição, o seguinte exemplo ilustra um exemplo:

![image](https://user-images.githubusercontent.com/49655530/123293949-4f330680-d50c-11eb-9051-b0acf41d16d3.png)

*atenção que os medicamentos e os exercícios possuem um scroll horizontal pois existe mais informação como a privacidade*

A opção atribuir visibilidade quando é a prescrição selecionada apresenta os medicamentos, exercícios e tratamentos privados da prescrição e é possível torná-los públicos selecionam o elemento em questão e clicar no botão atribuir visibilidade:

![image](https://user-images.githubusercontent.com/49655530/123294374-b0f37080-d50c-11eb-846d-437531ffcf45.png)






