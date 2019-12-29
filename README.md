# CannonLord
Game 2D

1. A pasta Cannonlord possui todo o código fonte do jogo. O arquino do executavel no link do one drive, possui um arquivo README sobre como executar o jogo... https://1drv.ms/u/s!Ah4Q-vF_ROSljm7bv2C2PolZdtub?e=x7Wx8w

2. O código e projeto foram organizados de forma hierárquica(de acordo com que o projeto foi sendo feito) e alfabetica(para uma maior organização).

3. Em geral, o jogo é basicamente o mesmo, apenas com assets diferentes. Foi adicionado:
- Mais tipos de inimigos. Levou em torno de 1 hora, já que foi basicamente mudar o sprite e a movimentação do inimigo base;
- Um tipo a mais de disparo liberado ao destruir um item. Levei um pouco mais de 40 minutos,  para fazer o segundo disparo funcionar de forma fluida, precisei fazer a lógica entre 3 scripts;
- Contador de vida( quando os inimigos passam por você o contador diminui, e quando chega a zero, dá game over). Levei 30 minutos, é uma lógica simples, ao passar por um colisor atrás do canhão, a variável responsavel pela sua vida diminui, e quando chega a 0, o jogo para e mostra o GAME OVER. Tendo o player a opção de reiniciar ou fechar o game;
- Um botão para fechar o jogo. Levei menos de 5 minutos, já que é basicamente um botão invocando o comando Application.Quit().
