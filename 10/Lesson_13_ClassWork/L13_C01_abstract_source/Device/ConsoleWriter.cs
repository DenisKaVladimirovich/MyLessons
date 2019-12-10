using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace L13_C01_abstract_source
{
	/// <summary>
	/// Implements the Console wrapper for convenient work with colors in the console.
	/// Initializes console to work with Unicode encoding.
	/// </summary>
	public class ConsoleWriter
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ConsoleWriter"/> class.
		/// </summary>

		public ConsoleWriter() : this(CultureInfo.InvariantCulture)
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ConsoleWriter"/> class.
		/// </summary>
		/// <param name="cultureInfo">The culture information.</param>
		public ConsoleWriter(CultureInfo cultureInfo)
		{
			Thread.CurrentThread.CurrentCulture = cultureInfo;
			Thread.CurrentThread.CurrentUICulture = cultureInfo;
			Console.InputEncoding = Encoding.Unicode;
			Console.OutputEncoding = Encoding.Unicode;
		}

		/// <summary>
		/// Transparent wrapper for Console.WriteLine method.
		/// </summary>
		/// <param name="text">The text to be written out.</param>
		public void WriteLine(string text)
		{
			Console.WriteLine(text);
		}

		/// <summary>
		/// Transparent wrapper for Console.WriteLine method with params.
		/// </summary>
		/// <param name="text">The text to be written out.</param>
		/// <param name="args">Arguments</param>
		public void WriteLine(string text, params object[] args)
		{
			Console.WriteLine(text, args);
		}

		/// <summary>
		/// Wrapper for Console.WriteLine method with red font color.
		/// </summary>
		/// <param name="text">The text to be written out.</param>
		public void WriteLineWithRed(string text)
		{
			WriteLineWithColor(text, ConsoleColor.Red);
		}

		/// <summary>
		/// Wrapper for Console.WriteLine method with green font color.
		/// </summary>
		/// <param name="text">The text to be written out.</param>
		public void WriteLineWithGreen(string text)
		{
			WriteLineWithColor(text, ConsoleColor.Green);
		}

		/// <summary>
		/// Wrapper for Console.WriteLine method with yellow font color.
		/// </summary>
		/// <param name="text">The text to be written out.</param>
		public void WriteLineWithYellow(string text)
		{
			WriteLineWithColor(text, ConsoleColor.Yellow);
		}

		/// <summary>
		/// Wrapper for Console.WriteLine method with cyan font color.
		/// </summary>
		/// <param name="text">The text to be written out.</param>
		public void WriteLineWithCyan(string text)
		{
			WriteLineWithColor(text, ConsoleColor.Cyan);
		}

		private void WriteLineWithColor(string text, ConsoleColor color)
		{
			ConsoleColor restoreColor = Console.ForegroundColor;
			Console.ForegroundColor = color;
			Console.WriteLine(text);
			Console.ForegroundColor = restoreColor;
		}
	}
}
