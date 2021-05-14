### OrderTracker.Solution

_By Jeremy Banka_

## Technologies Used

- 🎵 C# / .NET 5 Framework
- 🎛️ ASP.NET Core Server
- 🪒 Razor Templating
- 🧪 MS Test Adapter & Framework
- 💅 SCSS to CSS via Ritwick's Live Sass Compiler
- 🛠️ Tooling: Omnisharp, Prettier
- 💚 Fonts designed in Glyphs.app

## Description

...

## Setup/Installation Requirements

- Get the source code: `$ git clone https://github.com/jeremybanka/OrderTracker.Solution`
- Compile and run the WebApp as you save changes: `$ dotnet watch run` in `WebApp/`
- Also, run the tests as you save changes: `$ dotnet watch test` in `Tests/`

### Styling

If you want to mod the styles, you'll need a way to turn the source SCSS into compiled CSS. I recommend the following:

- Use VS Code.
- Install "**Live Sass Compiler**" extension by Ritwick Dey.
- Click "**Watch Sass**". You'll see this option show up in your status bar, bottom right of your editor, in any repo holding `.scss` files.
- Now, when you save an `.scss` file, the corresponding `.css` and `.css.map` will update! 😃
- `dotnet watch run` won't know that though. You'll have to save a `.cs` or `.cshtml` file, then reload to see your styling changes applied. 🙄
- Also, disable cache in your browser's Network dev tools.

## Known Bugs

- none identified

## License

Gnu Public License ^3.0

## Contact Information

hello at jeremybanka dot com
