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

This website is an exercise in practicing RESTful routing practices using a Bakery tracking orders from vendors as example data.

In this codebase you will find examples of:

- Exhaustively-tested Models that represent Vendor and Order.
- Pages assembled with Razor that reveal user-created data.
- Utility methods that find specific user-created orders and vendors.
- Three MVC controllers that handle HTML requests for the homepage, vendors, and orders.
- Guid implementation in lieu of simple tally-ids.
- A homepage that gives dynamic greetings using some very tight C# _switch expression_ syntax. Something JS doesn't have!

## Setup/Installation Requirements

- Get the source code: `$ git clone https://github.com/jeremybanka/OrderTracker.Solution`
- Compile and run the WebApp as you save changes: `$ dotnet watch run` in `WebApp/`
- Also, run the tests as you save changes: `$ dotnet watch test` in `Tests/`

#### Tooling (💡 = 📎)

Anyone remember Clippy? What a nice, helpful guy!

Microsoft has built some nice tools for C# that actually teach you new techniques as you work, just like that notorious little paperclip, but way more helpful. Unfortunately, you do need to do a little work to invite Clippy into your VS Code.

- First make sure you have **C#** extension by Microsoft installed. It probably got recommended to you when you opened your first `.cs` file.
- Now, give Clippy the power he needs:
  ```
  "omnisharp.enableRoslynAnalyzers": true,
  "omnisharp.enableEditorConfigSupport": true,
  ```
  add the above snippet to your `settings.json` and save.
- Now, Clippy will mark up redundancies and inefficiencies in your C# with squiggly blue underlines. Prepare to be amazed!

Keep in mind, 💡 is what Clippy looks like in VS Code. This will show up at the beginning of lines where Clippy's got ideas for improvements.

#### Styling 💅

If you want to mod the styles, you'll need a way to turn the source SCSS into compiled CSS. I recommend the following:

- Use VS Code.
- Install "**Live Sass Compiler**" extension by Ritwick Dey.
- Click "**Watch Sass**". You'll see this option show up in your status bar, bottom right of your editor, in any repo holding `.scss` files.
- 😃 Now, when you save an `.scss` file, the corresponding `.css` and `.css.map` will update!
- 🙄 `dotnet watch run` won't know that though. You'll have to save a `.cs` or `.cshtml` file, then reload to see your styling changes applied.
- ☝️🤓 Also, disable cache in your browser's Network devtools, and keep devtools open.

## Known Bugs

- none identified

## License

Gnu Public License ^3.0

## Contact Information

hello at jeremybanka dot com
