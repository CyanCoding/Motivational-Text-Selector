# Motivational Text Selector
This is a handy program in C# that will read from the provided JSON file
and output the quote and auther into two variables, `quote` and
`author` (very intuitive naming scheme).

This can be used in a wide range of areas, such as a daily motivation toast
notification on your desktop, a text display in your app, or a positive daily email.

## Implementation
Though this program is quite simple, there are a few things you should know.

- Instead of using an external library, like [Json.NET](https://www.newtonsoft.com/json), this
program uses a text regex splitter to maintain its lightweightness. You should never have any
interference with this, but it would be a good idea to take a look at it anyway in case you 
add more quotes (line 19 of [main.cs](https://github.com/CyanCoding/Motivational-Text-Selector/blob/main/main.cs#L19)).
- There are a few quotes that are exceedingly long and may not work for all display
formats. The longest being 232 characters. If this is an issue for your program, you
can implement a function that re-picks a quote until it finds one of your suitable size.
Most quotes in this list are less than 150 characters.

## Credit
The original list of quotes and basis of this program was inspired by
the gist from [@Signed0](https://gist.github.com/signed0). Check that out [here](https://gist.github.com/signed0/d70780518341e1396e11).
I copied his `json` file and added ~30 more quotes. Then I created the C# integration.
If you are using Python, be sure to check out his gist because he has a code sample there.
