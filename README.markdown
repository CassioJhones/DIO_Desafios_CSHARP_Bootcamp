# Desafio 3
Você deve criar um programa que crie um objeto jogador com nome, nacionalidade, idade e posição.<br/>O jogador deve ser criado a partir de uma classe "Jogador" com o método "novo" e os atributos mencionados.

**Entrada** <br/>O programa deve ler as informações do jogador nessa ordem: 
```
nome: string
nacionalidade: string
idade: inteiro
posição: strig
```
**Saída** <br/>
O programa deve imprimir as informações do jogador criado, uma por linha, com a mensagem "Jogador criado!" no início.<br/>As informações devem ser exibidas na seguinte ordem: nome, nacionalidade, idade e posição (com a mensagem "Posição:" na frente). <br/> 
Jogador criado!
[nome]
[nacionalidade]
[idade]
Posição: [posição] <br/>
**Exemplos**
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. <br/> Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.
| Entrada       | Saida  |
| ------------- | -------------- |
| Ronaldo         | Jogador criado!      |
| Brasil       | Ronaldo       |
| 46        | Brasil |
| Atacante        | 46|
||Posição: Atacante|
---
# Desafio 4 - Utilizando Construtores
No mundo dos RPGs, a criação do personagem é um momento importante e emocionante para os jogadores! Durante esse processo, o jogador deve escolher o nome, a raça, a classe e outras características importantes para o personagem.

Crie uma classe chamada **Personagem** que tenha os seguintes atributos: **nome (string), raça (string), classe (string), nível (inteiro), vida (inteiro) e mana (inteiro)**.<br/>A classe deve ter um construtor que recebe como parâmetros o nome, a raça e a classe do personagem.<br/>O nível e a vida devem ser iniciados com valores padrão (1 e 10 , respectivamente). Além disso, crie um método chamado **exibir_status** que exibe na tela o nome, a raça, a classe, o nível, a vida e a mana do personagem.

**Entrada** <br/>
A entrada deve conter as informações necessárias para a criação do personagem, como nome, raça e classe.

**Saída** <br/>
A saída deve conter a frase "Status:" seguida das informações do método "exibir_status", ou seja, deve exibir na tela o nome, a raça, a classe, o nível e a vida do personagem. Conforme exemplos abaixo.

---

# Desafio 5
Em jogos de RPG, os personagens frequentemente possuem subclasses que representam especializações em determinadas áreas de combate, como por exemplo, "mago", "guerreiro", "ladino", etc. Neste desafio, você deve criar duas classes, "Personagem" e "Subclasse", que ilustrem o conceito de herança em POO.

Crie a classe **Personagem** que possua o atributo "nome" e "mana".

Crie a classe "**Subclasse**" que herda de "**Personagem**" e acrescenta o atributo "**dano_base**" e o método "**calcular_dano**", que recebe como argumento a quantidade de mana que será usada no ataque e retorna o dano causado pelo ataque, que é calculado como o valor de "**dano_base**" multiplicado pela quantidade de mana usada.

**Entrada** <br/>
A entrada será dada pela chamada da classe "**Subclasse**" e seus métodos, para obter os valores dos atributos de cada personagem e a quantidade de mana usada no ataque.<br/>Os valores a serem recebidos serão:<br/>

**nome**: nome do personagem<br/>
**mana**: quantidade de mana do personagem<br/>
**dano base**: referente ao dano base da subclasse<br/>
Importante: a entrada deverá ocorrer de acordo com a ordem das informações fornecidas acima.<br/>

**Saída** <br/>
A saída deverá ser a impressão da mensagem "Nome do personagem atacou e causou X de dano!", onde "Nome do personagem" é o nome do personagem fornecido na entrada e "X" é o valor de dano calculado pela subclasse a partir da quantidade de mana usada no ataque. Conforme exemplos abaixo.

**Exemplos** <br/>
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

| Entrada       | Saida  |
| ------------- | -------------- |
| Sauron         | sauron atacou e causou 900 de dano!      
| 30            
| 30        
