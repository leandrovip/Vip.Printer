<h2 align="center"><strong>Vip.Printer</strong> - Impressão em mini-impressoras de um jeito simples e fácil :card_index:</h2>

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

Biblioteca para realizar **impressões em mini‑impressoras (não fiscais)** com os sets de comandos **ESC/POS**, **ESC/Bematech** e **ESC/Daruma** — funcionando por **RAW**, **TCP/IP)** e **Serial (RS‑232/USB‑Serial)**.  
Suporta marcas como **Bematech, Elgin, Epson, Sweda, Tanca, Daruma, Dimep, ControliD, Jetway, Tomate**, entre outras.

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
- Auto Teste

## Requisitos

- **.NET Standard 2.0** (lib)
- Compatível com **.NET Framework 4.6.1+**
- Bibliotecas utilizadas como dependência `System.IO.Ports`, `System.Drawing.Common` ambas na versão 6.0.0

## Instalação

```powershell
Install-Package Vip.Printer
```

> **Dica de Encoding**: para em .NET Core/5+/Android Xamarin/MAUI **registre os code pages na inicialização do projeto**:

```csharp
System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
```

---

## 🚀 Como começar

### 1) Modo rápido (construtores antigos — compatíveis)

```csharp
using Vip.Printer;
using Vip.Printer.Enums;

// Impressora local instalada (RAW/Spool)
var p1 = new Printer("MINHA_IMPRESSORA", PrinterType.Epson);
p1.WriteLine("Olá ESC/POS!");
p1.PartialPaperCut();
p1.PrintDocument();

// Impressora de rede (porta 9100)
var p2 = new Printer("192.168.0.50:9100", PrinterType.Epson, ProtocolType.Network);
p2.WriteLine("Impressão pela rede");
p2.PrintDocument();
```

### 🔹 Novo padrão recomendado (com `PrinterSettings`)

```csharp

var settings = PrinterSettings.Create()
    .WithPrinterName("Elgin I9")
    .WithProtocol(ProtocolType.Raw)
    .WithPrinterType(PrinterType.Epson)
    .WithEncoding(Encoding.GetEncoding("IBM860"))         // opcional
    .WithColumns(normal: 48, condensed: 64, expanded: 24) // opcional
    .Build();

var p = new Printer(settings);

// Exemplo simples
p.AlignCenter();
p.BoldMode("Vip.Printer");
p.NewLine();
p.WriteLine("Impressão via Spool (nome da impressora)");
p.Separator();
p.PartialPaperCut();
p.PrintDocument();
```

> **Quando usar:**
>
> - **RAW**: quando a impressora estiver instalada/local/compartilhada na estação (nome da impressora, porta ou nome do compartilhamento).
> - **Network**: impressoras via REDE (ex.: `ip:porta` - 192.168.0.1:9100). Caso não passe a porta, a biblioteca assume por padrão 9100.
> - **Serial**: quando ligada à porta COM ou USB/Serial (defina as propriedades da porta `Serial`).

### 🔹 RAW (compartilhamento/porta local)

```csharp
using Vip.Printer;
using Vip.Printer.Enums;

// Mantido construtores antigos para retrocompatibilidade
var p = new Printer("MINHA_IMPRESSORA", PrinterType.Epson);

p.WriteLine("Olá, Vip.Printer!");
p.Separator();
p.WriteLine("Estou usando o protocolo RAW!");
p.PartialPaperCut();
p.PrintDocument();
```

### 🔹 REDE (TCP/IP – ex: 192.168.0.50:9100)

```csharp
using Vip.Printer;
using Vip.Printer.Enums;

// Dica: Caso passe somento número do IP, será assumido a porta 9100 como padrão.

var settings = PrinterSettings.Create()
    .WithPrinterName("192.168.1.100")
    .WithProtocol(ProtocolType.Network)
    .WithPrinterType(PrinterType.Epson)
    .WithColumns(normal: 48, condensed: 64, expanded: 24) // opcional
    .Build();

var p = new Printer(settings);

p.AlignCenter();
p.BoldMode("Pedido #123");
p.NewLine();
p.QrCode("https://sistemaviperp.com.br");
p.PartialPaperCut();
p.PrintDocument();
```

### 🔹 SERIAL (porta serial/usb serial)

```csharp
using Vip.Printer;
using Vip.Printer.Enums;

var settings = PrinterSettings.Create()
    .WithPrinterName("COM10")
    .WithProtocol(ProtocolType.Serial)
    .WithPrinterType(PrinterType.Epson)
    .WithSerialOptions(9600, 8, Parity.None, StopBits.One, Handshake.None)
    .Build();

var p = new Printer(settings);

p.AlignCenter();
p.ExpandedMode("Impressão via Serial");
p.NewLine();
p.WriteLine("Estou usando a porta COM10");
p.FullPaperCut();
p.PrintDocument();
```

---

## Formatação de texto e alinhamento

```csharp
p.AlignLeft();
p.WriteLine("Texto normal");

p.ItalicMode("Texto Itálico");
p.BoldMode("Texto Negrito");
p.UnderlineMode("Texto Sublinhado");

p.ExpandedMode(PrinterModeState.On);
p.WriteLine("Expandido");
p.ExpandedMode(PrinterModeState.Off);

p.CondensedMode(PrinterModeState.On);
p.WriteLine("Condensado");
p.CondensedMode(PrinterModeState.Off);

p.NewLines(2);           // múltiplas quebras de linha
p.Separator();           // linha de separação (-----)
```

## Largura da fonte (colunas)

```csharp
p.NormalWidth();
p.WriteLine("Largura Normal");
p.DoubleWidth2();
p.WriteLine("Largura 2");
p.DoubleWidth3();
p.WriteLine("Largura 3");

// Ajuste fino via colunas (se necessário)
p.ConfigureCols(normal: 48, condensed: 64, expanded: 24);
```

## Códigos de barras e QR Code

```csharp
p.Code128("ABC123456");
p.Code39("VIP123");
p.Ean13("7891234567890");

p.QrCode("https://seu.link/aqui");                     // tamanho padrão
p.QrCode("https://seu.link/aqui", QrCodeSize.Size6);   // tamanho custom
```

## Imagens

```csharp
p.Image("caminho/arquivo.bmp");                 // de arquivo
p.Image(streamDoLogo);                          // de stream
p.Image(bytesDoLogo);                           // de byte[]
p.Image(minhaImagemBitmap, highDensity: true);  // de Image (System.Drawing)
```

> Observação: a imagem é rasterizada para a largura da cabeça térmica seguindo o comando do set (Esc/POS/Bema/Daruma).

## Gaveta e Guilhotina

```csharp
p.OpenDrawer();         // abre gaveta
p.PartialPaperCut();    // corte parcial
p.FullPaperCut();       // corte total
```

## Inicialização, teste e buffer

```csharp
p.InitializePrint(); // envia sequência de inicialização (Reset)
p.AutoTest();        // imprime teste do set de comandos
p.TestPrinter();     // imprime uma demo completa

p.Clear();           // limpa o buffer antes de montar outro documento
p.PrintDocument(2);  // imprime 2 cópias do buffer atual
```

## Codificação (acentos) – IBM850 / IBM860

- **Padrão**:
  - Para **Bematech**: `Encoding.GetEncoding(850)` (IBM850).
  - Para **Epson/Daruma** (via Esc/POS/EscDaruma): `Encoding.GetEncoding("IBM860")`.
- **Recomendação** (evitar erro “Encoding 860 not found” em .NET Core/Android):
  ```csharp
  Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
  // e então, se quiser, force um encoding específico:
  p.ConfigureEncoding(Encoding.GetEncoding("IBM860"));
  ```
- Se preferir outro code page (ex.: 1252), defina no construtor ou via `ConfigureEncoding`.

## Usando uma **Engine customizada**

Você pode plugar qualquer método de comunicação que implemente `IEngine` — por exemplo, para **logar em arquivo** (tests) ou enviar via **Bluetooth**.  
Quando uma engine custom é informada, o `ProtocolType` do `PrinterSettings` é **ignorado**.

### 1) FileEngine (dump binário para testes)
```csharp
using Vip.Printer.Interfaces.Engine;

public sealed class FileEngine : IEngine
{
    private readonly string _path;
    public FileEngine(string path) => _path = path ?? throw new ArgumentNullException(nameof(path));

    public bool Send(string printer, byte[] content)
    {
        var dir = System.IO.Path.GetDirectoryName(_path);
        if (!string.IsNullOrEmpty(dir)) System.IO.Directory.CreateDirectory(dir);
        System.IO.File.WriteAllBytes(_path, content ?? Array.Empty<byte>());
        return true;
    }
}

// Uso
var engine = new FileEngine(@"C:\temp\saida-escpos.bin");

var settings = PrinterSettings.Create()
    .WithPrinter("dummy")
    .WithPrinterType(PrinterType.Epson)
    .WithEngine(engine)
    .Build();

var printer = new Printer(settings);
printer.WriteLine("Imprimindo (na prática, gravando bytes ESC/POS em arquivo)...");
printer.PrintDocument();
```

## Protocolos de comunicação

- **RAW**: imprime em fila local/compartilhada (porta LPT/USB/compartilhamento).
- **REDE (TCP/IP)**: use `IP + Porta` (ex.: `192.168.0.50:9100`).
- **SERIAL**: defina porta (ex.: `COM3`). Parâmetros da serial são lidos de `PrinterSettings` quando `Protocol=Serial`.

## Troubleshooting (erros comuns)

- **“Não foi possível acessar a impressora: X”**  
  Verifique nome/compartilhamento, IP:porta, permissões e se a impressora está online.
- **“Image file not found”**  
  Caminho do arquivo inválido. Use caminho absoluto ou `File.Exists` antes de chamar `Image(...)`.
- **“QR-Code não impresso corretamente”**  
  Verifique se o set de comando informado é o mesmo da impressora. Para impressora como bematech, pode ser necessário atualizar 
- **Acentos saindo com caracteres estranhos / exceção de Encoding**  
  Registre os code pages (`Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)`) e/ou selecione manualmente `IBM850/IBM860`. Faça a impressão do auto teste e verifique o encoding configurado.
- **Nada imprime ao chamar `PrintDocument()`**  
  Garanta que o buffer foi montado (`Write/WriteLine/...`) antes de imprimir. Use `TestPrinter()` para validar, se necessário.

## Impressoras testadas

| Marca / Modelo     | EscPos | EscBema | EscDaruma |
| ------------------ | ------ | ------- | --------- |
| Bematech MP-2500   | ✅     | ✅      |           |
| Bematech MP-4000   | ✅     | ✅      |           |
| Bematech MP-4200   | ✅     | ✅      |           |
| Bematech MP-4800   | ✅     |         |           |
| Daruma DR-700      |        |         | ✅        |
| Daruma DR-800      |        |         | ✅        |
| Dimep D-Print DUAL | ✅     |         |           |
| Elgin i7           | ✅     |         |           |
| Elgin i9           | ✅     |         |           |
| Elgin VOX          | ✅     |         |           |
| Evadin Ep26m       | ✅     |         |           |
| Epson TM-20        | ✅     |         |           |
| ControliD Print iD | ✅     |         |           |
| Tanca TP-550       | ✅     |         |           |
| Tanca TP-650       | ✅     |         |           |
| Jetway JP-880      | ✅     |         |           |
| Tomate MDK-080/081 | ✅     |         |           |

> Dica: mesmo sendo **Esc/POS**, alguns modelos exigem ajustes de colunas/encoding.

## Release Notes

**04/11/2025 - v2.0.10**
- Adiciona novo padrão de configuração da biblioteca com novo construtor
- Adiciona protocolo de comunicação via porta SERIAL
- Adiciona possibilidade de adicionar engine customizada implementando a interface `IEngine`

**29/06/2022 - v2.0.6**
- Melhoria no comando de acionamento da gaveta para ESC/Bema

**16/05/2022 - v2.0.4**
- Adiciona protocolo de comunicação via REDE (tcp/ip)

**05/02/2021 - v1.0.22**
- Corrige o método NewLine

**10/11/2020 - v1.0.21**
- Adiciona o parâmetro 'copies' no método PrintDocumet para informar a quantidade de cópias a serem impressas

**20/10/2020 - v1.0.20**
- Corrige impressão do código de barras 'CODE128' no set de comandos EscPos

## Licença
MIT
