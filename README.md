
<h2 align="center"><strong>Vip.Printer</strong> - Impressão em mini-impressoras de um jeito simples e fácil :page_facing_up: :card_index:</h2> 

<p align="center">
  <a href="https://raw.githubusercontent.com/leandrovip/Vip.Printer/master/LICENSE">
    <img src="https://img.shields.io/github/license/leandrovip/Vip.Printer" />
  </a>
  
  <a href="https://www.nuget.org/packages/Vip.Printer/">
    <img alt="Nuget" src="https://img.shields.io/nuget/dt/Vip.Printer?label=NuGet%20downloads&style=flat-square">
  </a>
  
  <a href="https://www.nuget.org/packages/Vip.Printer/">
     <img alt="NuGet" src="https://img.shields.io/nuget/v/Vip.Printer.svg">
  </a>
</p>

Biblioteca para realizar impressões (mini-impressoras / impressora não fiscal) utilizando comandos Esc/Bema, Esc/Daruma e Esc/Pos. Possibilita utilizar diversas impressoras e de diversas marcas como Bematech, Elgin, Epson, Sweda, Tanca, Daruma, Jetway, etc.



## Pré requisitos

- .Net Framework 4.5+
- .Net Standard 2.0

## Instalação via NuGet

```
Install-Package Vip.Printer
```

## Exemplo de uso rápido

```c#
using Vip.Printer;

/* 
Instancie a classe Printer

Para instanciar a classe é necessário dois parâmetros:
- printerName (Nome da impressora, porta ou o caminho do compartilhamento)
- printerType (Set de comandos que será utilizado. PrinterType.Bematech, PrinterType.Epson ou PrinterType.Daruma)
*/ 

var printer = new Printer("MP2500", PrinterType.Bematech); 

printer.Append("Meu texto aqui!");
printer.PartialPaperCut();
printer.PrintDocument();
```

## Funcionalidades disponíveis

- Alinhamento
- Negrito
- Itálico
- Sublinhado
- Expandido
- Condensado
- Tamanho da Fonte
- Abertura de Gaveta (dinheiro)
- QRCode
- Imagem
- Código de Barras (EAN13, CODE128, CODE39)
- Guilhotina
- Propriedades com o número limite de colunas
- Número de cópias

## Comandos Implementados

* [x] EscBema
* [x] EscDaruma
* [x] EscPos

## Impressoras testadas

| Marca / Modelo     	| EscPos 	| EscBema 	| EscDaruma 	|
|--------------------	|--------	|---------	|-----------	|
| Bematech MP-2500   	|✅       | ✅        |           	|
| Bematech MP-4000   	|✅   	   | ✅       	|           	|
| Bematech MP-4200   	|✅   	   | ✅       	|           	|
| Bematech MP-4800   	|✅   	   |         	|           	|
| Daruma DR-700      	|        	|         	|✅         	|
| Daruma DR-800      	|       	|         	|✅         	|
| Dimpe D-Print DUAL 	|✅     	|         	|           	|
| Elgin i7           	|✅     	|         	|           	|
| Elgin i9           	|✅     	|         	|           	|
| Elgin VOX          	|✅     	|         	|           	|
| Evadin Ep26m       	|✅     	|         	|           	|
| Epson TM-20        	|✅     	|         	|           	|
| ControliD Print iD 	|✅     	|         	|           	|
| Tanca TP-550       	|✅     	|         	|           	|
| Tanca TP-650       	|✅     	|         	|           	|
| Jetway JP-880      	|✅     	|         	|           	|

## Release Notes

- **05/02/2021 - v1.0.22**
- Corrige o método NewLine
- **10/11/2020 - v1.0.21**
- Adiciona o parâmetro 'copies' no método PrintDocumet para informar a quantidade de cópias a serem impressas
- **20/10/2020 - v1.0.20**
- Corrige impressão do código de barras 'CODE128' no set de comandos EscPos

# Licença
MIT
