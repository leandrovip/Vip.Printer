
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

Dúvidas, sugestões e PR´s são bem vindos, abra uma issue :)

## Pré requisitos

- .Net Framework 4.5+
- .Net Standard 2.0

## Instalação via NuGet

```
Install-Package Vip.Printer
```

## Exemplo de uso

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

## Funcionalidades

- Alinhamento
- Negrito
- Itálico
- Sublinhado
- Expandido
- Condensado
- Tamanho da Fonte
- Abertura de Gaveta (dinheiro)
- QRCode
- Código de Barras (EAN 13, EAN 128, CODE39)
- Guilhotina
- Propriedades com o número limite de colunas

#### Comandos Implementados

* [x] EscBema
* [x] EscDaruma
* [x] EscPos

#### Impressoras testadas

**_EscBema_**

* [x] Bematech MP-2500
* [x] Bematech MP-4200

**_EscDaruma_**

* [x] Daruma DR-700

**_EscPos_**

* [x] Bematech MP-2500
* [x] Bematech MP-2800
* [x] Bematech MP-4200
* [x] Elgin I9
* [x] Elgin VOX
* [x] Epson TM-T20
* [x] Tanca TP-650
* [x] Tanca TP-550
* [x] Jetway JP-880

# Licença
MIT


