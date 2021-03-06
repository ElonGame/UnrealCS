using System;
namespace UnrealEngine
{
	/// <summary>Represents the appearance of an SEditableTextBox</summary>
	public partial struct FEditableTextBoxStyle
	{
		/// <summary>Border background image when the box is not hovered or focused</summary>
		public FSlateBrush BackgroundImageNormal;
		/// <summary>Border background image when the box is hovered</summary>
		public FSlateBrush BackgroundImageHovered;
		/// <summary>Border background image when the box is focused</summary>
		public FSlateBrush BackgroundImageFocused;
		/// <summary>Border background image when the box is read-only</summary>
		public FSlateBrush BackgroundImageReadOnly;
		/// <summary>Padding</summary>
		public FMargin Padding;
		/// <summary>Font family and size to be used when displaying this text.</summary>
		public FSlateFontInfo Font;
		/// <summary>The foreground color of text.</summary>
		public FSlateColor ForegroundColor;
		/// <summary>The background color applied to the active background image</summary>
		public FSlateColor BackgroundColor;
		/// <summary>The read-only foreground color of text in read-only mode.</summary>
		public FSlateColor ReadOnlyForegroundColor;
		/// <summary>Padding around the horizontal scrollbar</summary>
		public FMargin HScrollBarPadding;
		/// <summary>Padding around the vertical scrollbar</summary>
		public FMargin VScrollBarPadding;
		/// <summary>Style used for the scrollbars</summary>
		public FScrollBarStyle ScrollBarStyle;
		
	}
	
}
