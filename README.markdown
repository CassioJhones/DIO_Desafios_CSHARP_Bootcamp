# Desafio 3
Você deve criar um programa que crie um objeto jogador com nome, nacionalidade, idade e posição.<br/>O jogador deve ser criado a partir de uma classe "Jogador" com o método "novo" e os atributos mencionados.

**Entrada** <br/>O programa deve ler as informações do jogador nessa ordem: 
```
nome: string
nacionalidade: string
idade: inteiro
posição: strig
```
**Saída** <br/> O programa deve imprimir as informações do jogador criado, uma por linha, com a mensagem "Jogador criado!" no início.<br/>As informações devem ser exibidas na seguinte ordem: nome, nacionalidade, idade e posição (com a mensagem "Posição:" na frente).<br/> 
Jogador criado!
[nome]
[nacionalidade]
[idade]
Posição: [posição]
**Exemplos**
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.
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

**Entrada** <br/> A entrada deve conter as informações necessárias para a criação do personagem, como nome, raça e classe.

**Saída** <br/>
A saída deve conter a frase "Status:" seguida das informações do método "exibir_status", ou seja, deve exibir na tela o nome, a raça, a classe, o nível e a vida do personagem. Conforme exemplos abaixo.
