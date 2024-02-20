Explosão Cartesiana

A explosão cartesiana ocorre quando há uma combinação incorreta de tabelas em uma consulta SQL, resultando 
em uma multiplicação do número de linhas retornadas. 

Isso geralmente acontece quando você faz uma junção (join) entre tabelas sem especificar corretamente as 
condições de junção, ou quando você esquece de incluir condições de filtro adequadas. 

Query Splitting

O Query Splitting, ou divisão de consultas, é um recurso do EF Core que permite dividir uma consulta LINQ 
em várias consultas SQL separadas. Isso pode ser útil para otimizar o desempenho de consultas complexas, 
especialmente quando se trata de evitar a explosão cartesiana.

Ele foi introduzido no Entity Framework Core 5.0 para melhorar o desempenho de consultas que envolvem 
relacionamentos de muitos para muitos ou um para muitos. 

Este recurso divide a consulta em partes menores que são executadas de forma independente no banco de dados,
reduzindo assim a quantidade de dados retornados e melhorando o desempenho geral da consulta.

Este recurso pode ser aplicado usando o método AsSplitQuery() :

var resultado = ctx.Clientes.AsSplitQuery().Include(b => b.Pedidos).ToList();
