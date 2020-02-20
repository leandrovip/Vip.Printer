[![Nuget count](https://img.shields.io/nuget/v/Vip.Printer.svg)](https://www.nuget.org/packages/Vip.Printer/)

# Vip.Printer  

Biblioteca para realizar impressões em mini-impressoras utilizando comandos Esc/Bema e Esc/Pos, possibilitando utilizar diversas impressoras e de diversas marcas como Bematech, Elgin, Epson, Sweda, etc.

Dúvidas, sugestões e PR´s são bem vindos, abra uma issue :)

## Pré requisitos

- .Net Framework 4.6.2+

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
- printerType (Set de comandos que será utilizado. PrinterType.Bematech ou PrinterType.Epson)
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

#### Comandos Implementados

* [x] EscBema
* [x] EscPos

#### Impressoras testadas

**_EscBema_**

* [x] Bematech MP-2500

**_EscPos_**

* [x] Elgin I9
* [x] Epson TM-T20
* [x] Tanca TP-650
* [x] Tanca TP-550
* [x] Jetway JP-880

# Licença
MIT


