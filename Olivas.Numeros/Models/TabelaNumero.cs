using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Olivas.Numeros.Models
{

    public class Numeros
    {
        public int ValorLetra { get; set; }
        public string Letra { get; set; }
    }
    public static class Tabela
    {
        public static List<KeyValuePair<string, int>> ListaValorLetras = new List<KeyValuePair<string, int>>()
        {
                 new KeyValuePair<string, int>("a", 1),
                 new KeyValuePair<string, int>("b", 2),
                 new KeyValuePair<string, int>("c", 3),
                 new KeyValuePair<string, int>("d", 4),
                 new KeyValuePair<string, int>("e", 5),
                 new KeyValuePair<string, int>("f", 8),
                 new KeyValuePair<string, int>("g", 3),
                 new KeyValuePair<string, int>("h", 5),
                 new KeyValuePair<string, int>("i", 1),
                 new KeyValuePair<string, int>("j", 1),
                 new KeyValuePair<string, int>("k", 2),
                 new KeyValuePair<string, int>("l", 3),
                 new KeyValuePair<string, int>("m", 4),
                 new KeyValuePair<string, int>("n", 5),
                 new KeyValuePair<string, int>("o", 7),
                 new KeyValuePair<string, int>("p", 8),
                 new KeyValuePair<string, int>("q", 1),
                 new KeyValuePair<string, int>("r", 2),
                 new KeyValuePair<string, int>("s", 3),
                 new KeyValuePair<string, int>("t", 4),
                 new KeyValuePair<string, int>("u", 6),
                 new KeyValuePair<string, int>("v", 6),
                 new KeyValuePair<string, int>("x", 5),
                 new KeyValuePair<string, int>("w", 6),
                 new KeyValuePair<string, int>("y", 1),
                 new KeyValuePair<string, int>("z", 7),
                 new KeyValuePair<string, int>("é", 7),
                 new KeyValuePair<string, int>("í", 3),
                 new KeyValuePair<string, int>("ó", 9),
                 new KeyValuePair<string, int>("á", 3)
        };

        public static List<KeyValuePair<int, string>> ListaExpressao = new List<KeyValuePair<int, string>>()
        {
                new KeyValuePair<int, string>(1,
                     "O número um corresponde ao líder, às pessoas influentes, pioneiras, inventivas e planejadoras – embora muitas vezes essas " +
                     "pessoas realizem seus projetos sem levar em conta os envolvidos. Tendem a dominar, consciente ou inconscientemente, todos os seus conhecidos. Em vista da sua tremenda ousadia, vive a sonhar com grandes empreendimentos, pioneiros, sempre à procura de novidades, visando o presente e o futuro. O seu êxito profissional, afetivo ou pessoal, depende exclusivamente do seu modo de pensar, falar e proceder, pois como é individualista, dificilmente aceita conselhos ou sugestões de quem quer que seja. Em virtude da sua personalidade de aspecto arrogante e ditatorial, encontrará, ao longo da vida inúmeras dificuldades de relacionamento, sejam elas de cunho afetivo, pessoal ou mesmo profissional, levando-o a fazer amigos e inimigos com grande facilidade. Trabalhos subalternos, sem movimentação (como contador, caixa de banco, etc.), o deprimem, e diríamos até, o deixam “estressado”, pouco à vontade e insatisfeito. Deve trabalhar por conta própria ou em cargos de chefia, pois como tem os ouvidos “sensíveis”, não gosta de receber ordens, principalmente quando essa ordem parte de alguém com estudo inferior. Possui emoções poderosas e habilidades para dar e receber amor. Logo, é importante encontrar uma forma de expressar os seus sentimentos em vez de buscar realização em interesses financeiros. Se ficar desanimado, pode cairnos dramas emocionais de outras pessoas, pois a sua sensibilidade precisa encontrar uma via de escape. A ordem e o método são, em geral, benefícios para você, embora um plano de vida definido seja um pré-requisito para fazer bom uso do seu tremendo potencial. ORIENTAÇÃO: Em vista de ter tendência a começar muitas coisas e não terminá-las, deve adquirir conhecimentos, prudência, ponderação e sabedoria, para poder desenvolver o seu imenso potencial de realização e levar a bom termo os seus objetivos. "),
                new KeyValuePair<int, string>(2,
                     "O dois, apesar de não ser ambicioso, consegue tudo que deseja, mas sempre pela persuasão, nunca pela força. No lado negativo de seu caráter, destaca-se a hesitação constante e a falta de iniciativa, tendo tendência para adiar decisões importantes por qualquer motivo, levando-o a situações delicadas, principalmente no âmbito profissional e afetivo. Normalmente usa de destreza e sabedoria, trabalhando mais nos “bastidores”, ou seja, na retaguarda, para levar alegria e amor a todos os seus conhecidos. É cooperativo, de certa maneira tímido, vulnerável e até passivo, porém sempre atento a todos os detalhes de seu ambiente. Nasceu para trabalhar em conjunto com outras pessoas, dificilmente se adaptando a o comando, seja de que nível for. É detalhista e prefere fazer uso das suas habilidades inatas lidando com pessoas e satisfazendo seu desejo de eterna harmonia. Parte do seu sucesso provém do fato de aplicar suas habilidades e saber transformar a teoria em prática. Além disso, o ser dois é muito trabalhador, sempre pensando no sucesso; é, também, de certa forma ambicioso e com grande poder de liderança. Atento aos detalhes, é inventivo e sabe como ninguém solucionar problemas, seja de que nível for. Como é uma pessoa leal, grande parte da sua segurança é construída com amor e amizade; bons relacionamentos são importantes para a sua realização. ORIENTAÇÃO: O dois era chamado pelos antigos de a “mãe dos números e do casamento”. Como a sua grande virtude é a compreensão dos processos do conhecimento oculto, deve sempre cultivar este dom, a fim de poder viver condignamente, sem esperar que alguém ou algo o faça movimentar-se."),

                new KeyValuePair<int, string>(3,
                     "O três é o número da mais alta sabedoria e valor, da harmonia e da ação, do amor perfeito, da ternura e da força d’alma. É tremendamente apaixonado pela família (mesmo que não aparente), gosta de receber e dar amor e sente-se muito feliz em poder contribuir para a felicidade alheia. É ambicioso e dificilmente desiste dos seus ideais, seus objetivos. É um ser criativo e normalmente tem muitos amigos divertidos, além de possuir uma elevada percepção de beleza, cor e forma. O aspecto leve e espirituoso da sua personalidade sugere que gosta de se divertir e de se comunicar, e esses predicados, quando num elemento culturalmente desenvolvido, leva-o à procura de respostas para as questões mais profundas da vida, o que, no final das contas, acaba levando-o a explorar áreas mais espirituais ou místicas. Detesta receber ordens e trabalhar em uma profissão ou posição inferior, pois como sabe ter poderes e qualidades superior- res, também sabe como tirar proveito de qualquer situação que o possa fazer feliz. ORIENTAÇÃO: A vontade de aprender e a aversão à rotina indicam que você pode passar por diversas experiências na sua busca por uma carreira que o desafie mentalmente. " +
                     "Com a maneira persuasiva com que usa as palavras, pode ser bem sucedido no mundo da comunicação, vendas, escrita, arte ou área editorial, sendo, é claro, o chefe ou trabalhando por conta própria, pois tem grande aversão a ser mandado. " ),

                new KeyValuePair<int, string>(4,
                    "O quatro é o número da perseverança e da imortalidade, da descoberta e da consumação, da firmeza e do propósito, da realização das esperanças, das regras, dos poderes e da vontade. O novo lhe assusta e sente-se mais à vontade lidando com atividades rotineiras e já consagradas pela experiência. Gosta de construir coisas, mesmo que aparentemente não tenham maior serventia, pois é dotado de grande habilidade manual. Não suporta pessoas hipócritas, desonestas, preguiçosas e com falta de visão do futuro, e estas deficiências o tornam deprimido e triste. Não gosta de discussões fúteis, sem motivo aparente. Jamais guarda rancor, ressentimentos ou ódio de qualquer espécie, esquecendo rapidamente qualquer ofensa ou constrangimento. Sendo um espírito superior, o seu amor ao próximo é, simultaneamente, glória e dever. Usualmente, pode cooperar e se sair bem em trabalhos de equipe; entretanto, como não gosta de receber ordens, é preferível trabalhar por conta própria. É muito importante ser original, criar as suas próprias ideias e tomar as próprias decisões. Precisa aprender a ser persuasivo e não vigoroso ou autoritário. ORIENTAÇÃO: Como gosta da sua liberdade, evite fazer julgamentos ou criticar demais as pessoas, pois elas podem ficar ressentidas com as suas decisões e, assim, não lhe prestarem bons serviços ou não colaborarem com seus projetos. "),
                new KeyValuePair<int, string>(5,
                    "O cinco é o número dos criativos, dos ousados, dos agitados e dos amantes da liberdade. A característica deste número o impele a viajar pelo mundo sempre em busca de saber, de novas experiências e também prazer. É um ser sociável, agradável e sempre bem vindo em festas e reuniões. Gosta de ocupações diferentes, aquelas que o permitem estar em contato com pessoas, com o público, e que o deixem agir e exprimir-se livremente. Detesta receber ordens, principalmente de pessoas com estudo ou capacidade inferior às suas. Também não gosta de trabalhos pesados, enfadonhos, cansativos, preferindo os intelectuais, ou aqueles que o colocam em destaque, como chefe de vendas, de marketing, de criação, ou qualquer outro que implique no desejo de viver e pesquisar. Possui grande capacidade para lidar com quaisquer tipos de pessoas, sejam elas ricas, influentes ou intelectuais. O cinco, às vezes, tem surtos extraordinários de energia e coragem que lhe permitem reagir rapidamente a situações e agarrar as oportunidades. Possui uma mente excelente e precisa, e é capaz de ter pensamentos profundos, além de uma inclinação a pensar de forma técnica e analítica. O seu espírito independente o estimula a ver as coisas de uma maneira original e a buscar a liberdade pessoal. Porém, deve evitar ser voluntarioso ou obstinado e se tornar negativo e pouco comunicativo. ORIENTAÇÃO: Como terá muitas experiências na vida, deve usar essas experiências e o seu temperamento corajoso para levar até o fim os seus projetos, pois é de certa forma dispersivo, não conseguindo terminar o que começa, tendo mais começo do que fins. "),
                new KeyValuePair<int, string>(6,"O seis é um número de certa maneira contraditório; é o número da confusão e junção, da união e sedução, do vício e da virtude, da incerteza no casamento, do amor, da atração dos sexos e da beleza. Significa todos os tipos de problemas e discórdias, mas também é capaz de purificação pelo conhecimento e de uma vida elevada. A família é a base de sustentação de toda a sua vida. Amar e ser amado; eis o desejo maior do número seis. E quando privado desse amor, sente-se completamente perdido, sem saber o que fazer e como agir. Aparentemente calmo, pode explodir quando o contradizem ou criticam, principalmente quando nasce nos dias 29, 30, 31 ou primeiro de cada mês. O seis quer ver todos saudáveis, alegres e repletos de sucesso e felicidade. É pródigo em favorecer os outros, nada esperando em retribuição, passando inúmeras vezes por “otário”, pois as pessoas que favorece dificilmente retribuem os favores recebidos. Apesar de suas qualidades expressivas e brilhantes, pode ter dificuldades em fazer escolhas e tomar decisões. Como tem diversos interesses que o levam a diferentes direções, é muito importante ter um senso de propósito. Sem isso, pode ficar dividido entre os seus ideais e o desejo de satisfação material. Um lado da sua natureza pode ter uma forte atração por dinheiro, luxo e um estilo de vida indolente, mas o outro tem um desejo inspirador que pode levá-lo a trabalhar duro para realizar seus ideais. Qualquer que seja a sua escolha, terá muitas oportunidades e a habilidade de driblar as situações difíceis, graças ao seu charme e persuasão. Excelente marido, esposa ou amante, entrega-se por inteiro aos seus amores ou amizades, exigindo a mesm dedicação por parte dos outros, o que nem sempre acontece, frustrando-o e desestabilizando-o emocionalmente por longos períodos. ORIENTAÇÃO: Para se elevar e conquistar fama e fortuna deve procurar profissões de interesse humanitário, sempre incentivado pelos que ama. Deve, também, concentrar sua energia e não se preocupar com o que outras pessoas dizem ou fazem. Aprenda a dizer “não” sem medo de ofender os outros. "),
                new KeyValuePair<int, string>(7,"O sete é perfeccionista, de certa maneira arredio, por vezes calado, demora a esquentar um relacionamento, interessado em filosofia, religiosidade, política e assuntos extrafísicos. De grande intuição e discernimento, raramente segue as ideias alheias e só faz o que acredita. É vibrante em seus propósitos, honesto, leal, amigo, profundo, elevado moralmente, não gostando de futilidades e ilegalidades, e as atividades ou atos que as contenham, o deprimem e o entristecem. Como é um ator natural, muitas vezes passa uma imagem de autoconfiança. Em geral é perspicaz e inteligente, com um forte sexto sentido, pode avaliar rapidamente as pessoas e situações. Isso faz com que tenha um desempenho melhor quando ocupa uma posição de liderança em vez de se desgastar em trabalhos físicos. Mesmo que seja generoso, tanto quanto à sua disponibilidade de tempo quanto de dinheiro, pode se tornar expansivo e indulgente em excesso. Felizmente, é aberto às críticas, o que lhe permite usar a auto-análise como uma ferramenta valiosa, com poder de influenciar os demais. Por vezes é incompreendido, considerado estranho, um ser solitário, incomum, diferente. ORIENTAÇÃO: Deve controlar a sua vida e estabelecer primeiro uma base sólida. Deve aproveitar o que a vida tem de melhor e evitar o comodismo. Deve trabalhar em prol da humanida- de, em serviços que beneficiem a coletividade e que de alguma maneira o satisfaçam intelectual e também espiritualmente. Precisa meditar e receber inspiraçãodo eu interior. "),
                new KeyValuePair<int, string>(8,"O oito é considerado o número da atração e da repulsão, da vida, de todos os tipos de lutas, da separação, ruptura, destruição, expectativas e ameaças. Também é conhecido como o “portão da eternidade”. Dificilmente c o n s e g u e expressar seus sentimentos, parecendo frio e evasivo; a realidade é outra: é muito carinhoso, meigo, amoroso, carente de afeição e com muito calor humano. Em virtude destas características (ser uma coisa e parecer outra), tem tendência ao materialismo, ao acúmulo de bens materiais e também uma certa ganância de querer possuir a maior quantidade de dinheiro e bens possíveis. É organizadíssimo e muito dedicado à profissão, sendo excelente para lidar com situações concretas que requerem discernimento e constância. É austero, prático, direto, seguro de si, por vezes generoso, mas também se pode tornar violento quando as coisas não correm como deseja. Como é dotado de alto senso de justiça, jamais deve fazer qualquer transação comercial fraudulenta, pois essa “falta” poderá lhe ser muito prejudicial ao longo da existência. Normalmente não perde tempo lutando pela fortuna, pois sabe com absoluta certeza que conseguirá atingir seus objetivos. Com excelente capacidade de avaliação, lida com o dinheiro e as questões materiais de forma instintiva. Pode ter golpes de sorte ocasionais, combinando o seu sexto sentido com informações inesperadas. Como pode passar por períodos de instabilidade financeira, precisa equacionar o problema de como viver bem sem ser extravagante. A sua autoridade natural o leva a ocupar posições de responsabilidade, nas quais pode usar a sua capacidade de organização. E será melhor se isso envolver algum tipo de atividade criativa. ORIENTAÇÃO: Como é progressista, dá grande importância ao dinheiro, ao status social e deseja constantemente expressar livremente os seus sentimentos, deve evitar situações monótonas ou excesso de rigidez. Terá mais chance de se realizer como alto executivo, comerciante ou trabalhando por conta própria. "),
                new KeyValuePair<int, string>(9,"O nove é misterioso, silencioso e liga-se ao plano astral. É o número da sabedoria, da virtude, da experiência, dos mistérios, da moralidade, do valor, da soberania, do amor humano, da obscuridade, da proteção e dos frutos do mérito. Enfim, é o número dos universalistas, dos generosos, dos seres humanos sensíveis aos sofrimentos alheios e vivem constantemente em busca da “verdade”, da compreensão, adaptando-se a trabalhos que visam o engrandecimento do ser humano, não medindo esforços e sacrifícios para fazer o que pensa ser certo, ou seja, amar, proteger e defender opróximo. O nove é um pensador nato e dispõe de grande capacidade de raciocínio, observação, criatividade e compreensão, levando-o a conhecer o âmago e as qualidades de coisas e fatos. Deve sempre ser impessoal, pois como é universalista, o materialismo pode-lhe causar sérios desapontamentos e aborrecimentos, principalmente com respeito a “amigos” e parentes que considera íntegros e incapazes de ações ilícitas, mas que na realidade são falsos. Tem excelente capacidade para ganhar dinheiro, e também para perdê-lo. Mas o mais extraordinário, é o fato de “nunca” lhe faltar dinheiro para as despesas do dia-a-dia. A fé interior é um importante fator para a sua autoconfiança e sem ela pode passar por fases de insegurança, reserva ou falta de auto-estima. Perspicaz e de mente aguçada, entende as coisas rapidamente e as utiliza em seu benefício. Embora às vezes possa se preocupar muito com questões materiais, é através do uso da sabedoria interior e compreensão espiritual que pode superar a perspectiva fria ou cética. Ousando ser espontâneo e justo ao mesmo tempo, mas sem perder a competitividade, pode desafiar a si mesmo e aos outros sem se sentir arrogante ou poderoso. Frequentemente atraído por indivíduos criativos, tem grande necessidade de amor e compreensão que se opõe à sua aparência forte e assertiva. ORIENTAÇÃO: Como nasceu para ser livre, não deve se apegar a nada nem a ninguém, e sim amar e trabalhar em prol de toda a humanidade, sem nada esperar em troca. Evite ser destrutivo ou vingativo. Tente perceber a necessidade das outras pessoas e evite ser autocentrado ou crítico; evite dominar os outros com as suas opiniões. A compaixão e o amor trazem as maiores recompensas. "),
                new KeyValuePair<int, string>(11,"O onze é o número do poder, da bravura, da energia, do sucesso em aventuras destemidas, da liberdade. Suas vibrações são lunares e seus possuidores são idealistas, intuitivos, sensíveis, místicos, imaginativos e pensadores inspirados. O ser onze dificilmente é bem sucedido como negociante, sentindo-se mais à vontade em profissões agitadas, como política, marketing, administração de grandes empresas ou grandes projetos esotéricos, sociais e ideológicos. Profundo conhecedor da mente humana, normalmente se destaca dos demais, pois sendo um “número mestre”, consegue vislumbrar em seus amigos e inimigos, defeitos e virtudes que em outros números seria impossível. Tem fé em seus ideais e dificilmente volta atrás em suas decisões. Procura sempre ser justo, leal, compreensivo e viver em harmonia com todos. A vibração especial deste número sugere que o idealismo, a inspiração e a inovação são altamente importantes para o seu possuidor. Uma combinação de humildade e confiança o desafia a trabalhar para alcançar a independência financeira e espiritual. Através da experiência, pode aprender a lidar com os dois lados da sua natureza e desenvolver uma atitude menos extremista, acreditando nos seus sentimentos. Em geral, o onze tem muita energia e gosta de vitalidade, mas deve evitar o excesso de ansiedade e a falta de sentido prático Se não seguir os dogmas esotéricos e estudos profundos do “hermetismo”, pode-se tornar indolente, indeciso e sujeito à vontade alheia, sendo sugado e feito de empregado por seres muito mais inferiores do que ele. Como é um ser superior, normalmente atrai inveja e conflito das pessoas ao seu redor, fazendo amizades e inimizades com grande facilidade e, assim, dificultando a conclusão dos seus objetivos. ORIENTAÇÃO: Como todos os grandes seres humanos, aqueles que se destacam dos demais, o onze também tem certas dificuldades de adaptação ao meio ambiente, ao convívio com seres de inferior categoria, que não o compreendem, não o apóiam e ain- da o criticam. Deve ir em frente nos seus ideais sem se preocupar com o que os outros pensam de si. "),
                new KeyValuePair<int, string>(22,"As pessoas cujos nomes correspondem a vinte e dois – o número supremo – possuem todas as qualidades boas dos outros números. Se desejar algo que em princípio pareça impossível, vá em frente, pois com certeza conseguirá atingir o seu objetivo, e até com certa facilidade, pois é habilidoso, idealista, organizado e tem grande potencial de realização. Tem, ainda, outras qualidades: integridade moral, honestidade nata, inspiração divina, disciplina técnica e social, constância nos objetivos e grande capacidade para levar até ao fim um projeto ou um objetivo. Não é muito fácil conviver com ele, pois sendo “superior”, normalmente não se adapta a situações preconcebidas e muito menos gosta de aceitar ordens de quem quer que seja, gostando de trabalhar sozinho ou então em cargos de chefia. A ambição pode levá-lo ao mundo dos negócios, no qual pode se sobressair graças à sua capacidade de organização e administra- ção. Isto sugere também que pode vir a ser bem- sucedido nas áreas industrial, bancária, imobiliária e de merchandising. A sua visão e sua imaginação ativa podem levá- lo a seguir carreiras no teatro, fotografia, cinema ou decoração de interiores. A sua habilidade natural para lidar com as pessoas pode ser canalizada para profissões que envolvam o trato com o público, como comunicação, educação, medicina, trabalho social ou advocacia. O seu discer nimento especial e compaixão podem levá-lo a trabalhar no mundo da cura, seja na medicina tradicional ou na alternativa. ORIENTAÇÃO: Pode-se tornar famoso, tanto nacional como internacionalmente, pois como tem grande capacidade de persuasão e destreza com as palavras, consegue convencer a todos com seus argumentos e ideias, que outras não devem ser se não as que visem o bem da humanidade.Todo e qualquer vício lhe é altamente prejudicial, principalmente o fumo. ")

        };

        public static List<KeyValuePair<int, string>> ListaMotivacao = new List<KeyValuePair<int, string>>()
        {
                new KeyValuePair<int, string>(1,
                  "LÍDER, AMBICIOSO,"+"\r\n"+
                  "Espírito pioneiro,  busca explorar e sua realização."+"\r\n"+
                  "Tem iniciativa .  Não gosta de receber ordens e é melhor em cargo superior."+"\r\n"+
                  "Se não tiver desenvolvido seu lado espiritual, pode se tornar egoísta e arrogante,"+"\r\n"+
                  "Com um jeito indelicado de tratar as pessoas."+"\r\n"+
                  "Existem certas dificuldades e acaba criando inimizades por isso."+"\r\n"+
                  "Algumas vezes, essas dificuldades também se estendem à convivência com a família e conjuge."+"\r\n"+
                  "ORIENTAÇÃO: Refine o seu trato com o próximo...dessa forma prosperará  em todas as áreas."),
                new KeyValuePair<int, string>(2,
                  "BUSCA amor e compreensão e na carreira  tem preferência com parcerias,  trabalhos cooperativos, não gostando muito de aparecer."+"\r\n"+
                  "Quer companheiro, casamento,  conforto."+"\r\n"+
                  "Tem um jeito sensível,  costuma ser cordial e prestativo."+"\r\n"+
                  "Por vezes se mostra muito passivo e carente, cuidado para que pessoas a sua volta não se aproveitem  de você."+"\r\n"+
                  "Prefere não expor muito suas ideias, escutando as dos outros."+"\r\n"+
                  "Se mistura com todo tipo de perfil , sem julgamentos."+"\r\n"+
                  "ORIENTAÇÃO: Aprenda a conviver com o público, se comunicar mais. Espalhe sua mensagem de harmonia."),
                new KeyValuePair<int, string>(3,"Ama um palco, uma plateia..."+"\r\n"+
                   "Almeja ser popular... ter muitos amigos … vivendo rodeado do que é belo."+"\r\n"+
                   "De natureza sonhadora e entusiasmada. Tem alta capacidade artística, com o espírito humano elevado , está sempre  levando alegria  aos que estão a sua volta. É  sincero ,com espírito de liberdade ,  sociabilidade."+"\r\n"+
                   "O número três  ama se divertir, é  amigável. Do tipo “ aparecido. Porém, tem grandes desafios ao fazer amizades,  pois gosta de interagir com  outros, que às vezes não estão tão receptivos aos seus interesses ."+"\r\n"+
                   "A realização emocional normalmente deriva de sua alegria de aprender sobre o amor e  compaixão."+"\r\n"+
                   "ORIENTAÇÃO: Por causa de seu altruísmo, cuidado para não assumir mais compromissos do que consegue cumprir... estude filosofia humana e procure fazer uma coisa por vez, indo até o fim o que começou."),
                new KeyValuePair<int, string>(4,"Necessita de ordem. QUER trabalhar metodicamente e não gosta muito de situações que fogem da rotina."+"\r\n"+
                    "Conservador , realista e equilibrado e, com quem pode-se contar ."+"\r\n"+
                    "UM Profissional  dedicado à profissão. Perfeccionista  PARA CONCLUIR UM TRABALHO BEM FEITO."+"\r\n"+
                    "GOSTA DE COISAS QUE PODE VER E TOCAR."+"\r\n"+
                    "Quando mais elevado, é um ser sério, firme como uma rocha. Gosta da sensação de proteção."+"\r\n"+
                    "Não gosta de surpresas."+"\r\n"+
                    "Obediente, trabalhador incansável, autodisciplinado,  precisa de estabilidade. Seja pessoal ou financeira,"+"\r\n"+
                    "Tende a não demonstrar emoções, mas por dentro são confiáveis."+"\r\n"+
                    "ORIENTAÇÃO: A evolução no plano material, vem através dos seus esforços contínuos e talentos profissionais ."+"\r\n"+
                    "Assim, pode conquistar tudo o que deseja, mas tenha planos que visem o bem da humanidade também. Aprenda a ser flexível ."),
                new KeyValuePair<int, string>(5,
                    "MUTÁVEL. Gosta de novas exzperiências, copisas modernas e novidades."+"\r\n"+
                    "Curioso, quer investigar."+"\r\n"+
                    "O raciocínio é rápido , se adaptando com facilidade."+"\r\n"+
                    "É SOCIALMENTE versátil,  amigo, possuindo várias amizades."+"\r\n"+
                    "Se sai bem em qualquer função, pois aprende rapidamente ."+"\r\n"+
                    "Se mudar  ou viajar, fazem bem à sua de vida."+"\r\n"+
                    "ORIENTAÇÃO: Se dedique a estudar psicologia..."+"\r\n"+
                    "Seja perseverante em seus objetivos, terminando o quecomeça."),
                new KeyValuePair<int, string>(6,"BUSCA harmonia pessoal e social. "+"\r\n"+
                    "Humanitário e idealista, tem compaixão."+"\r\n"+
                    ".Tendência a querer orientar ou consertar tudo o que está ruim no mundo."+"\r\n"+
                    "Gosta de raízes, família, lar e pessoas queridas."+"\r\n"+
                    "Tendência ao apreço à fertilidade , ama famílias grandes. Milagre da vida."+"\r\n"+
                    "É confiável, por isso alguns amigos  o procuram em épocas complicadas."+"\r\n"+
                    " É equilibrado, responsável e POSSUI TENDÊNCIA À se situar em assuntos domésticos , casa em ordem, animais de estimação, bons móveis..."+"\r\n"+
                    "De gosto refinados , gosta do que é elegante."+"\r\n"+
                    " TEM êxito social nos relacionamentos."+"\r\n"+
                    "ORIENTAÇÃO: Cuidado com as tendência à vaidade, se espiritualize."+"\r\n"+
                    "Aceite que possui certas limitações, terá assim a  harmonia desejada."),
                new KeyValuePair<int, string>(7,"Não gosta de confusão e barulho."+"\r\n"+
                    "Procura  descobrir o porquê das coisas."+"\r\n"+
                    "Ama liberdade,  tranquilidade, introspecção, para pensar."+"\r\n"+
                    "Possui boa intuição."+"\r\n"+
                    "O número da espiritualidade , possuindo uma sabedoria enorme e sempre em busca de mais."+"\r\n"+
                    "Possui integridade e senso de justiça "+"\r\n"+
                    "Para se unir em relacionamentos, deve analisar bem , pois se conjuge não for compatível isso o fará sofrer muito."+"\r\n"+
                    "Cuidado com a tendência ao ciúme."+"\r\n"+
                    "Não gosta de  injustiças e está sempre pronto a ajudar quem precise."+"\r\n"+
                    "RIENTAÇÃO: Drogas em geral,(bebdas, cigarro) são venenos para seu corpo."+
                    "SE viver próximo à água, (MAR, RIO...)será mais feliz."+"\r\n"+
                    "Busque autoconhecimento no campo afetivo, terapias etc, pra se relacionar melhor com parceiro."),
                new KeyValuePair<int, string>(8,
                    "Nasceu para negócios e ama essa luta."+"\r\n"+
                    "Quer poder, riqueza e sucesso. Está sempre bem motivado  em busca dos seus sonhos."+"\r\n"+
                    "Inteligente,  sabe por instinto enfrentar as lutas da vida."+"\r\n"+
                    "Tem poucos amigos, mas os que tem lhe são muito caros."+"\r\n"+
                    "Cuidado com a ambição anormal  , o que te torna autoritário e dominador."+"\r\n"+
                    "Se for bem desenvolvido culturalmente,   se torna muito eficiente naquilo que faz."+"\r\n"+
                    "Desenvolva suas habilidades para negócios  e execução."+"\r\n"+
                    "ORIENTAÇÃO: Continue persistente. Aja com dipomacia,  tolerância, para conseguir  o que deseja. APRENDA A perdoar e considerar as fraquezas dos outros."),
                new KeyValuePair<int, string>(9,
                    "Quer ensinar, aconselhar  à humanidade." +"\r\n"+
                    "MAL SABE, MAS tem um  subconsciente  genial." +"\r\n"+
                    "Mente perceptiva." +"\r\n"+
                    "Revestido de desinteresse material MAS SE NÃO FOR BEM  desenvolvido espiritualmente, pode se tornar orgulhoso, querendo elogio de todos." +"\r\n"+
                    "Apesar de sua compassividade, se ilude ou fica  frustrado quando percebe que os outros não compreendem suas perspectivas elevadas." +"\r\n"+
                    "Tendência a não ser compreendido por colegas de trabalho e com isso elimina  suas excelentes ideias." +"\r\n"+
                    "Dos obstáculos em sua vida, sabe muito bem se livrar e possui energia." +"\r\n"+
                    "Universalista, cheio de amor para dar." +"\r\n"+
                    "ORIENTAÇÃO: DESENVOLVA suas qualidades , procure viajar O mundo, conhecer novas pessoas,  ambientes , pra que não se torne solitário, introspectivo, podendo desenvolver depressão."
                    ),
                new KeyValuePair<int, string>(11,
                    "Visionário. Motiva ser grande e especial.Gosta que as pessoas o admirem, enfatizando seus pontos de vista e não dando valor aos pontos dos outros."+"\r\n"+
                    "Normalmente é atrativo, tanto na parte pessoal como em sociedade."+"\r\n"+
                    "É um ser idealista, que possui grande inspiração."+"\r\n"+
                    "Apesar de gostar que suas ideias se sobressaiam, algumas vezes se torna alguém que concilia contendas."+"\r\n"+
                    "Confiança e humildade te ajudariam a ter autodomínio espiritual e material ."+"\r\n"+
                    "Com o tempo e  experiência, pode aprender a lidar com isso."+"\r\n"+
                    "Não costuma concordar com isso, mas é sensível e magoa-se com coisas que outras pessoas nem ligariam."+"\r\n"+
                    "ORIENTAÇÃO: VOCÊ POSSUI rara intuição e uma capacidade que deve desenvolver,  seguindo seus pressentimentos. Grande potencial."+"\r\n"+
                    "Não tenha insegurança em relação ao dinheiro, supere a tendência a ser  calculista."
                    ),
                new KeyValuePair<int, string>(22,
                    "É  inspirado e eficiente , com grande potencial de realização."+"\r\n"+
                    "Número-mestre, quer dar  sua contribuição PARA HUMANIDADE"+"\r\n"+
                    "Tem necessidade de amor."+"\r\n"+
                    "UM Trabalhador , com capacidade de liderança , com profunda compreensão dos outros e das suas motivações."+"\r\n"+
                    "Se você for determinado, pode atingir o sucesso e a fortuna em sua jornada."+"\r\n"+
                    "Sentimentos profundos ."+"\r\n"+
                    "Possui grande  resistência e perseverança, mesmo em momentos difíceis."+"\r\n"+
                    "ORIENTAÇÃO: NÃO DEIXE SEUS padrões muito elevados, pra que não se torne antipático ou muito crítico. DESENVOLVA a compreensão e a persistência. TRABALHE em prol da humanidade, mas não se esqueça de você.")

        };
        public static List<KeyValuePair<int, string>> ListaImpressao = new List<KeyValuePair<int, string>>()
        {
                new KeyValuePair<int, string>(1,
                    "É um ser que quer amor, harmonia, parceria."+"\r\n"+
                    "Geralmente diplomático, pacífico, realiza conciliações ."+"\r\n"+
                    "Cuidado com essa atitude de querer sempre agradar a todos, pois isso pode te tornar dependente."+"\r\n"+
                    "Desenvolva autoconfiança, para superar essa tendência."+"\r\n"+
                    "POSSUI RESPONSABILIDADE, JUSTIÇA, calma."+"\r\n"+
                    "Gosta de ser confortado."+"\r\n"+
                    "Pelo seu jeito gentil, é visto pelos outros como alguém seguro."+"\r\n"+
                    "Ás vezes parece estar com a cabeça nas nuvens."+"\r\n"+
                    "Geralmente é alguém com simplicidade, discreto,  que não gosta de exibicionismo."+"\r\n"+
                    "ORIENTAÇÃO: Algumas pessoas no mundo, entendem simplicidade como  “fraqueza”. Por isso, se mostre mais dinâmico, criativo ."+"\r\n"+
                    "E busque inovação sem medo de erros, evite ficar estagnado."+"\r\n"),
                new KeyValuePair<int, string>(2,"É um ser que quer amor, harmonia, parceria."+"\r\n"+
                    "Geralmente diplomático, pacífico, realiza conciliações ."+"\r\n"+
                    "Cuidado com essa atitude de querer sempre agradar a todos, pois isso pode te tornar dependente."+"\r\n"+
                    "Desenvolva autoconfiança, para superar essa tendência."+"\r\n"+
                    "POSSUI RESPONSABILIDADE, JUSTIÇA, calma."+"\r\n"+
                    "Gosta de ser confortado."+"\r\n"+
                    "Pelo seu jeito gentil, é visto pelos outros como alguém seguro."+"\r\n"+
                    "Ás vezes parece estar com a cabeça nas nuvens."+"\r\n"+
                    "Geralmente é alguém com simplicidade, discreto,  que não gosta de exibicionismo."+"\r\n"+
                    "ORIENTAÇÃO: Algumas pessoas no mundo, entendem simplicidade como  “fraqueza”. Por isso, se mostre mais dinâmico, criativo ."+"\r\n"+
                    "E busque inovação sem medo de erros, evite ficar estagnado."+"\r\n"
                    ),
                new KeyValuePair<int, string>(3,"É social, popular, engraçado, criativo... Muitas vezes um verdadeiro artista."+"\r\n"+
                    "Gosta de se expressar."+"\r\n"+
                    "Demonstra personalidade e imaginação fértil."+"\r\n"+
                    "Equilibre suas qualidades para formar fundações sólidas na vida."+"\r\n"+
                    "Mesmo com tantas coisas positivas, esse perfil precisa desenvolver  auto-estima e  segurança emocional."+"\r\n"+
                    "ORIENTAÇÃO: EVITE ficar tão preocupado com projetos futuros, se aborrecendo com preocupação excessiva, pois isso prejudica o fígado e o coração."+"\r\n"
                    ),
                new KeyValuePair<int, string>(4,"É o número de alguém que faz!"+"\r\n"+
                    "Gosta de ordem e isso  te abrirá muitas portas."+"\r\n"+
                    "Trabalhadores, rígidos, fortes, o sustento para a família."+"\r\n"+
                    "Naturalmente simples."+"\r\n"+
                    "Sua ótima capacidade de organizar mostra que você precisa de estabilidade."+"\r\n"+
                    "Possui muita energia  e forte determinação para atingir seus objetivos."+"\r\n"+
                    "Gosta dos detalhes."+"\r\n"+
                    "ORIENTAÇÃO: Coloque suas ideias em ação. De alguma forma, você é a força da sua família."+"\r\n"+
                    "Cuidado com autoridade excessiva , com a vontade de controlar a vida dos outros e com a tendência à obesidade."+"\r\n"
                    ),
                new KeyValuePair<int, string>(5,"Possui intuição forte a ponto de conhecer profundamente  o caráter alheio."+"\r\n"+
                    "É interessante, agradável ."+"\r\n"+
                    "Sonha em viajar pelo mundo ou levar uma vida de aventura, por vezes até  sem vínculo."+"\r\n"+
                    "É alguém que sabe se defender e  dificilmente conseguem enganá-lo."+"\r\n"+
                    "Tem facilidade em amizades e também inimizades ."+"\r\n"+
                    "Não gosta de saberes superfíciais., gosta de descobrir o novo."+"\r\n"+
                    "Uma de suas maiores qualidades é entusiasmo, ao encarar as novidades na vida."+"\r\n"+
                    "Sempre terá uma aparência e jeito de ser jovial."+"\r\n"+
                    "Possui um desejo imenso de experimentar qualquer novidade  e o que a vida tem a lhe oferecer."+"\r\n"+
                    "ORIENTAÇÃO: O seu senso de humor e o físico são atrativos. Fique atento apenas na escolha de amizades, sociedades, parcerias."+"\r\n"
                    ),
                new KeyValuePair<int, string>(6,"SEIS é  perfeição nos números cabalistas ."+"\r\n"+
                    "É também o número do amor."+"\r\n"+
                    "É do tipo paternal por vezes."+"\r\n"+
                    "Tem sonhos e desejos de uma ter uma bela família, bela casa ( com flores no jardim inclusive)"+"\r\n"+
                    "Por vezes tem é contraditório,  pois possui harmonia e confusão nos relacionamentos. Não gosta de viver sozinho."+"\r\n"+
                    "É nobre interiormente."+"\r\n"+
                    "Geralmente dá o melhor de si quando tem liberdade pra agir profissionalmente."+"\r\n"+
                    "Lembre-se que por vezes é preciso ceder mesmo."+"\r\n"+
                    "ORIENTAÇÃO: Cuidado com seu jeito  ingênuo e generoso demais... valorizando quem não merece, pois pode ser explorado."+"\r\n"+
                    "APRENDA A DIZER NÃO,  a se ouvir, desenvolver intuição e só depois  tomar decisões. NÃO É porque você tem um bom caráter, que outras pessoas também tenham esse bom coração."+"\r\n"
                    ),
                new KeyValuePair<int, string>(7,"É um ser espiritual, sábio."+"\r\n"+
                    "Demonstra triunfo do espírito sobre o que é material."+"\r\n"+
                    "Tendência à ter  simpatia dos outros socialmente."+"\r\n"+
                    "Gosta de leituras, ambientes com atmosfera de paz e tranquilidade, como um refúgio."+"\r\n"+
                    "Possui natureza solitária, mesmo gostando de companhias ."+"\r\n"+
                    "É sincero e honesto, exigindo isso de volta."+"\r\n"+
                    "Sóbrio. Enigmático."+"\r\n"+
                    "É sensível, E TEM SENTIMENTOS profundos."+"\r\n"+
                    "CUIDE DE RELAXAR,  buscando ser alegre."+"\r\n"+
                    "Não deixe sua mente sobrecarregada, em momentos de stress."+"\r\n"+
                    "ORIENTAÇÃO: Cuidado com o detalhismo, aprenda A ENTENDER os outros e aceitar como eles são. Elimine do seu vocabulário a calúnia, críticas,   e só dê conselhos a quem pedir"+"\r\n"
                    ),
                new KeyValuePair<int, string>(8,"Se mostra imponente e com influência, mesmo que esteja com problemas  financeiros ou pessoais."+"\r\n"+
                    "Possui raciocínio rápido, mas com jeito  equilibrado."+"\r\n"+
                    "Que ser grande empreendedor, alguém poderoso, executivo e quer chefiar."+"\r\n"+
                    "Em momentos que lhe atingem seu amor próprio, se desestabiliza e tende ao  mau humor."+"\r\n"+
                    " Muito criativo, tem grande vigor."+"\r\n"+
                    " Sempre busca novas realizações."+"\r\n"+
                    "É bem dramático e possui aversão em obedecer. Também não gosta de receber crítica."+"\r\n"+
                    "SABE lidar muito bem com as pessoas , fazer contatos. Porém, oscila no comportamento, por vezes caloroso outras vezes indiferente."+"\r\n"+
                    "Gosta sempre de dar impressão de bom estado financeiro."+"\r\n"+
                    "Possui habilidade para negócios e se procurar desenvolver essas habilidades será melhor ainda."+"\r\n"+
                    "ORIENTAÇÃO: Cuidado com a arrogância."+"\r\n"+
                    "Desenvolva MAIS ATIVIDADES humanitárias."+"\r\n"
                    ),
                new KeyValuePair<int, string>(9,"É alguém que sempre atrai antipatia ou  simpatia de forma igual."+"\r\n"+
                    "É humanitário ,compreensivo em relação aos sofrimentos dos outros."+"\r\n"+
                    "Geralmente gosta de servir."+"\r\n"+
                    "Gosta de oferecer aconselhamento e se sente bem resolvendo problemas oferecendo afeto."+"\r\n"+
                    "Gosta de desvendar as coisas."+"\r\n"+
                    "UM ser inteligente e com bons conhecimentos, mesmo que na parte educacional tenha tido  educação precária."+"\r\n"+
                    "Normalmente inspira confiança , atingindo o que deseja."+"\r\n"+
                    "Normalmente sabe analisar o caráter das pessoas. Isso faz com que seja sociável, o que te leva a ajudar pessoas."+"\r\n"+
                    "ORIENTAÇÃO: Se te limitarem ou reprimirem, pode ter comportamentos rebeldes."+"\r\n"+
                    "PROCURE SER menos orgulhoso."+"\r\n"+
                    "APRENDA a se adaptar a situações diferentes."+"\r\n"+
                    "A cor preta não te é favorável, principalmente de dia."+"\r\n")
        };
        public static List<KeyValuePair<int, string>> ListaDestino = new List<KeyValuePair<int, string>>()
        {
                new KeyValuePair<int, string>(1,"PONTOS POSITIVOS: Perspicaz."+"\r\n"+
                    "Se sentir que um projeto  vale a pena, tem capacidade pra realizações extraordinárias. "+"\r\n"+
                    "Necessita  de reconhecimento e sucesso. "+"\r\n"+
                    "COSTUMAM SE DEDICAR para realizar isso."+"\r\n"+
                    "Cuidado com a tendência à arrogância, ao achar que o sucesso do grupo dependeu só de você.  Pois isso pode tornar difícil o convívio com  os outros, pois não é fácil conviver com esse tipo de pessoa. "+"\r\n"+
                    "Cuidado com sua atitude crítica e preocupada sobre você mesmo, isso pode pesar o seu sistema nervoso e ser um  obstáculo à sua realização pessoal."+"\r\n"+
                    "Isso também  pode isolá-lo dos outros, precisa ter fé em si  e nas suas ideias."+"\r\n"+
                    "ORIENTAÇÃO: PREFERÍVEL  trabalhar por conta própria ou em cargos superiores. Quando  trabalhar em grupo não seja  ditador e escute conselhos. Procure MEDITAR."+"\r\n"
                    ),
                new KeyValuePair<int, string>(2,"Gosta de associações com  pessoas, é aquele que contribui para a realização de qualquer projeto."+"\r\n"+
                    "Consegue ouvir ideias alheias e valorizá-las , criando um clima de  harmonia."+"\r\n"+
                    "POSSUI  habilidade diplomática."+"\r\n"+
                    "As pessoas admiram sua gentileza e os trabalhos em conjunto."+"\r\n"+
                    "É  leal em suas relações."+"\r\n"+
                    "Se importa em proteger seus familiares e também aos outros."+"\r\n"+
                    "Cuidado com a tendência ao acomodamento e a esperar que sempre os outros tomem a iniciativa.SE MOSTRE MAIS."+"\r\n"+
                    "Não perca excelentes oportunidades por causa disso. Cuidado também com tendências psicológicas negativas, pois corre o risco de se sacrificar. ORIENTAÇÃO: CONTINUE A cultivar a paciência e cooperação.  Seu principal atributo é a a união, parcerias, mas respeite aqueles que não querem se unir. Trabalhe sempre em parceria, mas não espere que tudo que caia do céu, tome mais atitudes."+"\r\n"
                    ),
                new KeyValuePair<int, string>(3,"PONTOS POSITIVOS: "+"\r\n"+
                    "É o destino da SOCIABILIDADE!"+"\r\n"+
                    "Versátil, alegre, talentoso, criativo, social...possui o dom artístico quando fala, quando escreve ou quando desenvolve qualquer outro tipo de arte. "+"\r\n"+
                    "Em sua  existência deve sempre procurar cultivar esses dons . Tudo o que você faz cresce e multiplica. "+"\r\n"+
                    "A comunicação, como um todo é o seu principal meio para ser próspero e muito feliz."+"\r\n"+
                    "Emoção e criatividade são as razões do seu sucesso, pois tem facilidade de expressão e também capacidade executiva. "+"\r\n"+
                    "Dinâmica, tem uma personalidade charmosa e sabe promover suas ideias. Se dedique!"+"\r\n"+
                    "É fácil que fique entediado, é muito vaidoso, sem paciência ,  exagerado,  tem tendência a irresponsabilidade em cumprir horários e tratar com desprezo pessoas com nível inferior ao seu. Se isso se manifesta, você se  torna extremamente insociável, disperso e com grande tendência a se entediar, a se isolar ( crises nervosas)"+"\r\n"+
                    "ORIENTAÇÃO: Por ter nascido com o dom da comunicação, deve usar esse dom para alcançar sucesso . Para isso, precisa desenvolver a autoestima e evitar as tendências a se preocupar ou se sentir inseguro emocionalmente, devendo manter sob controle suas necessidades e  excessos de atividades corriqueiras. Selecione as amizades, procure qualidade à quantidade."+"\r\n"
                    ),
                new KeyValuePair<int, string>(4,"PONTOS POSITIVOS: Destino de conquista, por meio do trabalho duro ."+"\r\n"+
                    "Cultive a paciência. Sua vida, costuma não ser muito fácil, em termos de retorno."+"\r\n"+
                    "Mas trabalhe com muita dedicação e  tudo o que conseguirá será sólido, eterno."+"\r\n"+
                    "Se dedica aos seus projetos e quase sempre é bem sucedido"+"\r\n"+
                    "Possui poucos amigos, porém sinceros.Prefere qualidade."+"\r\n"+
                    "Possui bom senso de visão, tem potencial para  conceitos originais . Isso te  ajuda a superar preocupações quanto à instabilidade financeira . "+"\r\n"+
                    "Viver em grupo pode ser extremamente difícil, pois gosta de coisas estáveis e estruturadas ,  o novo te traz incerteza .Pode ser julgado de chato, pelo seu  perfeccionismo e porque cobra demais os outros."+"\r\n"+
                    "Pense em ser justo e compreensivo com seu próximo."+"\r\n"+
                    "ORIENTAÇÃO:  Precisa praticar a justiça, ou terá muitos altos e baixos."+"\r\n"+
                    "Se relacione de forma positiva com todos e respeite o direito que todos tem de errar."+"\r\n"+
                    "Deve, também, se relacionar com pessoas inteligentes e com as quais possa compartilhar os seus interesses. "+"\r\n"
                    ),
                new KeyValuePair<int, string>(5,"PONTOS POSITIVOS: VIAJANTE"+"\r\n"+
                    "Deseja mudanças,  novidades, versatilidade, "+"\r\n"+
                    "Quer alterar e transformar. "+"\r\n"+
                    "Curte o que é moderno, diferente."+"\r\n"+
                    "Isso se estende pelo âmbito do CONHECIMENTO."+"\r\n"+
                    "É comunicativo,  receptivo, curioso, dotado de grande capacidade de discernimento. Se fortalece através do conhecimento."+"\r\n"+
                    "Procura estar sempre de bem com a vida.Por isso por vezes é chamado de irresponsável, coisa que não é!"+"\r\n"+
                    "Mentalmente ativo, AMA desafios intelectuais."+"\r\n"+
                    "Porém, quando não consegue o que quer, age de forma complicada."+"\r\n"+
                    "Cuidado com a vida financeira, pois tem tendência a comprar mais do que precisa. "+"\r\n"+
                    "Um ser com ampla visão de tudo e de todos, mas possui certa inconstância em seus objetivos. PROCURE TERMINAR O QUE COMEÇOU."+"\r\n"+
                    "ORIENTAÇÃO: Aprenda a selecionar o que é melhor a você, sem indecisão."+"\r\n"+
                    "Viva o presente, mas planeje o amanhã."+"\r\n"+
                    "Mantenha a ordem. "+"\r\n"+
                    "Admira pessoas poderosas, POR ISSO precisa de um parceiro que  tenha personalidade forte. Apesar de sociável, gosta de fazer coisas sozinho , enfrentando novos desafios."+"\r\n"+
                    "Prefere a companhia de pessoas inteligentes, PRA EXERCITAR SEU CÉREBRO."+"\r\n"
                    ),
                new KeyValuePair<int, string>(6,"PONTOS POSITIVOS: "+"\r\n"+
                    "Costuma ser educado, não suportando brigas . Gosta de manter tudo calmo . É o número da família, harmonia  e do amor. "+"\r\n"+
                    "Adora animais ou crianças ou plantas."+"\r\n"+
                    "De forte personalidade, equilibra com sua capacidade amorosa."+"\r\n"+
                    "É ambicioso mas também compreeensivo, fazendo qualquer coisa por quem ama. "+"\r\n"+
                    "Normalmente se dá bem em relacionamentos , pois é amável ."+"\r\n"+
                    "É MUITO sentimental, o que o torna vulnerável  ... confia nas aparências sem analisar a fundo."+"\r\n"+
                    "CUIDADO COM o acomodamento e falta de interesse. "+"\r\n"+
                    "Para estar bem consigo mesmo, precisa de tranquilidade."+"\r\n"+
                    "Necessita ser  incentivado, pois tem tendência a deixar tudo pela metade."+"\r\n"+
                    "ORIENTAÇÃO: PRECISA aprender a se ajustar em SITUAÇÕES pouco harmoniosas, a assumir o fardo dos outros.PRECISA  ser determinado, PERSEVERANTE para atingir as suas metas. "+"\r\n"+
                    "TEM potencial para trabalhar com o público, devido ao seu jeito ."+"\r\n"
                    ),
                new KeyValuePair<int, string>(7,"PONTOS POSITIVOS: É alguém  que busca na vida o entendimento,  conhecimento mais profundo."+"\r\n"+
                    "Apesar de não demonstrar tanto sentimentos altruístas, é alguém possuidor dessa característica."+"\r\n"+
                    "Busca  o lado oculto das coisas e pessoas. "+"\r\n"+
                    "Não se satisfaz com aparências, prefere conhecer a essência. "+"\r\n"+
                    "Possui necessidade constante de ter uma maior autoconsciência e se interessa por assuntos espirituais. "+"\r\n"+
                    "Deve aprender a valorizar as pessoas como elas são, pois elas são fruto daquilo que conseguiram absorver da vida e do convívio ."+"\r\n"+
                    "ORIENTAÇÃO: Destino de sabedoria e da introspecção, por isso precisa trabalhar seus poderes mentais. "+"\r\n"
                    ),
                new KeyValuePair<int, string>(8,"POSSUI capacidade para planejar e levar qualquer tipo de negócio. "+"\r\n"+
                    "Seu Destino é  ganho financeiro."+"\r\n"+
                    "Tem uma personalidade exigente. Mas também é muito generoso com os que ama. "+"\r\n"+
                    "É alguém justo, disciplinado, econômico, bom negociante."+"\r\n"+
                    "Bem confiante e curioso, tem inclinação à teimosia, podendo tornar-se impaciente.  "+"\r\n"+
                    "Sempre QUERENDO  ganhar dinheiro e  conquistas materiais,  se esquece da família, do lado sentimental. Às vezes até de si mesmo. "+"\r\n"+
                    "Cuidado com sua dificuldade em mostrar afeto , aparentando frieza nos relacionamentos . Pois no fundo, você é altamente emotivo, necessitando de ajuda,"+"\r\n"+
                    "ORIENTAÇÃO:  Desenvolva sua grande habilidade pra acúmulo material."+"\r\n"+
                    "PRECISA aprender que as pessoas precisam de atenção. Por isso, entenda que quanto maior a ostentação, mais as pessoas entenderão que você é autosuficiente e que você não precisa delas. "+"\r\n"
                    ),
                new KeyValuePair<int, string>(9,"PONTOS POSITIVOS: UNIVERSAL"+"\r\n"+
                    "Pessoa espirituosa. Seu desejo de ser bem sucedido vem de uma mistura de materialismo e idealismo."+"\r\n"+
                    "Tolerante e gentil. Possui intuição e  poder psíquico que pode inspirá-lo a buscar o caminho espiritual. "+"\r\n"+
                    "PRECISA que as pessoas ao seu redor estejam bem. É muito emotivo e bem sentimental. "+"\r\n"+
                    "Pense mais em você e no âmbito profissional.  CUIDADO com o complexo de inferioridade,  preocupação exagerada e a vontade de isolamento. "+"\r\n"+
                    "ORIENTAÇÃO: É importante servir , mas também  se divertir. "+"\r\n"+
                    "Livre-se dos preconceitos e ame mais o seu próximo."+"\r\n"+
                    "Seja tolerante e compreensivo ."+"\r\n"+
                    "Estabilizesse emocionalmente."+"\r\n"+
                    "Pode-se beneficiar viajando...Cuidado com comportamento escapistas."+"\r\n"+
                    "APROVEITE EM SUA VIDA sua grande capacidade para adquirir conhecimentos"+"\r\n"
                    ),
                new KeyValuePair<int, string>(11,"PONTOS POSITIVOS: "+"\r\n"+
                    "DESTINO PODEROSO. De pessoas intuitivas...Enxergam longe. O número-mestre 11."+"\r\n"+
                    "CUIDADO COM SUA impaciência e  nervosismo "+"\r\n"+
                    "Geralmente é uma pessoa enérgica, com grande potencial mental . Se trabalhar sua disciplina , consegue grande concentração para realizar suas metas."+"\r\n"+
                    "EXPRESSE o seu poder criativo."+"\r\n"+
                    "A perseverança É SUA  chave para o sucesso, e pode impressionar quando se especializa em algo."+"\r\n"+
                    "1dealismo, a inspiração."+"\r\n"+
                    "Cuidado coma tendência à vícios e desonestidade."+"\r\n"+
                    "PERCEBE com maior intensidade os defeitos do mundo e das pessoas, através da sua alta capacidade."+"\r\n"+
                    "CUIDADO pra não se tornar  insatisfeito com tudo."+"\r\n"+
                    "Mas essas insatisfações , servirão para melhorar seus conceitos sobre tudo . "+"\r\n"+
                    "Investigue o lado espiritual da vida, confie na própria intuição, tenha fé, se mantenha humilde."+"\r\n"+
                    "Use suas características poderosas para melhorar o planeta, os seus semelhantes e a sua vida. "+"\r\n"+
                    "Não exija demais dos outros. "+"\r\n"+
                    "Evite se preocupar demais e aprenda a trabalhar com os outros. Quando combina sua imaginação e sua  praticidade, obtém resultados excelentes."+"\r\n"
                    ),
                new KeyValuePair<int, string>(22,"PONTOS POSITIVOS: É o Destino de quem constrói e  se dedica de forma altruísta à humanidade. Sábio."+"\r\n"+
                    "Pessoas com esta vibração são geralemente precoces no que fazem.Nas áreas: material, social, mental ou espiritual."+"\r\n"+
                    "Conhecem da vida o profundo. Altamente intuitivo. "+"\r\n"+
                    "GERALMENTE  trabalhador, com capacidade nata para a liderança, de personalidade carismática e  compreensão profunda de suas motivações."+"\r\n"+
                    "Mesmo sendo reservado, se preocupa com o bem estar de todos."+"\r\n"+
                    "Os que posuem esta vibração e são mais competitivos, podem alcançar o sucesso e fortuna com  ajuda e o encorajamento dos outros."+"\r\n"+
                    "Pode se dedicar ao mundo das comunicações, política, educação, ajudando a humanidade."+"\r\n"+
                    "Possui  HABILIDADE PARA  entender e desenvolver processos de força extrafísica ."+"\r\n"+
                    "CUIDADO COM Tendência à arrogância,  ao egoísmo e a menosprezar o semelhante."+"\r\n"+
                    "ORIENTAÇÃO: Necessita entender que a  cooperação e serviço prestado também fazem parte do cotidiano. "+"\r\n"+
                    "Apesar de generoso, pode  ter forte tendência a uma vida de luxo .Não caia no escapismo e tenha uma perspectiva mais madura. Faça algo do que realmente gosta, para se realizar e ser bem-sucedido. "+"\r\n"+
                    "Destinado a ser Líder, pela sua capacidade executiva."+"\r\n")
        };
    }
}