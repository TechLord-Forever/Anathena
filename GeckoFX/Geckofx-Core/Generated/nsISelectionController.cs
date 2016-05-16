// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsISelectionController.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;


    /// <summary>
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
    [ComImport()]
	[Guid("b1ff7faa-8097-431d-b7f1-b0615e3cd596")]
	public interface nsISelectionController : nsISelectionDisplay
	{
		
		/// <summary>
        /// SetDisplaySelection will set the display mode for the selection. OFF,ON,DISABLED
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetDisplaySelection(short toggle);
		
		/// <summary>
        /// GetDisplaySelection will get the display mode for the selection. OFF,ON,DISABLED
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		short GetDisplaySelection();
		
		/// <summary>
        /// GetSelection will return the selection that the presentation
        /// shell may implement.
        ///
        /// @param aType will hold the type of selection //SelectionType
        /// @param _return will hold the return value
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISelection GetSelection(short type);
		
		/// <summary>
        /// ScrollSelectionIntoView scrolls a region of the selection,
        /// so that it is visible in the scrolled view.
        ///
        /// @param aType the selection to scroll into view. //SelectionType
        /// @param aRegion the region inside the selection to scroll into view. //SelectionRegion
        /// @param aFlags the scroll flags.  Valid bits include:
        /// SCROLL_SYNCHRONOUS: when set, scrolls the selection into view
        /// before returning. If not set, posts a request which is processed
        /// at some point after the method returns.
        /// SCROLL_FIRST_ANCESTOR_ONLY: if set, only the first ancestor will be scrolled
        /// into view.
        /// SCROLL_OVERFLOW_HIDDEN: if set, scrolls even if the overflow is specified
        /// as hidden.
        ///
        /// Note that if isSynchronous is true, then this might flush the pending
        /// reflow. It's dangerous for some objects. See bug 418470 comment 12.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollSelectionIntoView(short type, short region, short flags);
		
		/// <summary>
        /// RepaintSelection repaints the selection specified by aType.
        ///
        /// @param aType specifies the selection to repaint.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RepaintSelection(short type);
		
		/// <summary>
        /// Set the caret as enabled or disabled. An enabled caret will
        /// draw or blink when made visible. A disabled caret will never show up.
        /// Can be called any time.
        /// @param aEnable PR_TRUE to enable caret.  PR_FALSE to disable.
        /// @return always NS_OK
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCaretEnabled([MarshalAs(UnmanagedType.U1)] bool enabled);
		
		/// <summary>
        /// Set the caret readonly or not. An readonly caret will
        /// draw but not blink when made visible.
        /// @param aReadOnly PR_TRUE to enable caret.  PR_FALSE to disable.
        /// @return always NS_OK
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCaretReadOnly([MarshalAs(UnmanagedType.U1)] bool readOnly);
		
		/// <summary>
        /// Gets the current state of the caret.
        /// @param aEnabled  [OUT] set to the current caret state, as set by SetCaretEnabled
        /// @return   if aOutEnabled==null, returns NS_ERROR_INVALID_ARG
        /// else NS_OK
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCaretEnabled();
		
		/// <summary>
        /// This is true if the caret is enabled, visible, and currently blinking.
        /// This is still true when the caret is enabled, visible, but in its "off"
        /// blink cycle.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetCaretVisibleAttribute();
		
		/// <summary>
        /// Show the caret even in selections. By default the caret is hidden unless the
        /// selection is collapsed. Use this function to show the caret even in selections.
        /// @param aVisibility PR_TRUE to show the caret in selections.  PR_FALSE to hide.
        /// @return always NS_OK
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetCaretVisibilityDuringSelection([MarshalAs(UnmanagedType.U1)] bool visibility);
		
		/// <summary>
        ///CharacterMove will move the selection one character forward/backward in the document.
        /// this will also have the effect of collapsing the selection if the aExtend = PR_FALSE
        /// the "point" of selection that is extended is considered the "focus" point.
        /// or the last point adjusted by the selection.
        /// @param aForward forward or backward if PR_FALSE
        /// @param aExtend  should it collapse the selection of extend it?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CharacterMove([MarshalAs(UnmanagedType.U1)] bool forward, [MarshalAs(UnmanagedType.U1)] bool extend);
		
		/// <summary>
        /// CharacterExtendForDelete will extend the selection one character cell
        /// forward in the document.
        /// this method is used internally for handling del key.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CharacterExtendForDelete();
		
		/// <summary>
        /// CharacterExtendForBackspace will extend the selection one character cell
        /// backward in the document.
        /// this method is used internally for handling backspace key only when we're
        /// after UTF-16 surrogates.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CharacterExtendForBackspace();
		
		/// <summary>
        ///WordMove will move the selection one word forward/backward in the document.
        /// this will also have the effect of collapsing the selection if the aExtend = PR_FALSE
        /// the "point" of selection that is extended is considered the "focus" point.
        /// or the last point adjusted by the selection.
        /// @param aForward forward or backward if PR_FALSE
        /// @param aExtend  should it collapse the selection of extend it?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WordMove([MarshalAs(UnmanagedType.U1)] bool forward, [MarshalAs(UnmanagedType.U1)] bool extend);
		
		/// <summary>
        ///wordExtendForDelete will extend the selection one word forward/backward in the document.
        /// this method is used internally for handling ctrl[option]-backspace and ctrl[option]-del.
        /// @param aForward forward or backward if PR_FALSE
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void WordExtendForDelete([MarshalAs(UnmanagedType.U1)] bool forward);
		
		/// <summary>
        ///LineMove will move the selection one line forward/backward in the document.
        /// this will also have the effect of collapsing the selection if the aExtend = PR_FALSE
        /// the "point" of selection that is extended is considered the "focus" point.
        /// or the last point adjusted by the selection.
        /// @param aForward forward or backward if PR_FALSE
        /// @param aExtend  should it collapse the selection of extend it?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void LineMove([MarshalAs(UnmanagedType.U1)] bool forward, [MarshalAs(UnmanagedType.U1)] bool extend);
		
		/// <summary>
        ///IntraLineMove will move the selection to the front of the line or end of the line
        /// in the document.
        /// this will also have the effect of collapsing the selection if the aExtend = PR_FALSE
        /// the "point" of selection that is extended is considered the "focus" point.
        /// or the last point adjusted by the selection.
        /// @param aForward forward or backward if PR_FALSE
        /// @param aExtend  should it collapse the selection of extend it?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void IntraLineMove([MarshalAs(UnmanagedType.U1)] bool forward, [MarshalAs(UnmanagedType.U1)] bool extend);
		
		/// <summary>
        ///PageMove will move the selection one page forward/backward in the document.
        /// this will also have the effect of collapsing the selection if the aExtend = PR_FALSE
        /// the "point" of selection that is extended is considered the "focus" point.
        /// or the last point adjusted by the selection.
        /// @param aForward forward or backward if PR_FALSE
        /// @param aExtend  should it collapse the selection of extend it?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void PageMove([MarshalAs(UnmanagedType.U1)] bool forward, [MarshalAs(UnmanagedType.U1)] bool extend);
		
		/// <summary>
        ///CompleteScroll will move page view to the top or bottom of the document
        /// @param aForward forward or backward if PR_FALSE
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CompleteScroll([MarshalAs(UnmanagedType.U1)] bool forward);
		
		/// <summary>
        ///CompleteMove will move page view to the top or bottom of the document
        /// this will also have the effect of collapsing the selection if the aExtend = PR_FALSE
        /// the "point" of selection that is extended is considered the "focus" point.
        /// or the last point adjusted by the selection.
        /// @param aForward forward or backward if PR_FALSE
        /// @param aExtend  should it collapse the selection of extend it?
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CompleteMove([MarshalAs(UnmanagedType.U1)] bool forward, [MarshalAs(UnmanagedType.U1)] bool extend);
		
		/// <summary>
        ///ScrollPage will scroll the page without affecting the selection.
        /// @param aForward scroll forward or backwards in selection
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollPage([MarshalAs(UnmanagedType.U1)] bool forward);
		
		/// <summary>
        ///ScrollLine will scroll line up or down dependent on the boolean
        /// @param aForward scroll forward or backwards in selection
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollLine([MarshalAs(UnmanagedType.U1)] bool forward);
		
		/// <summary>
        ///ScrollCharacter will scroll right or left dependent on the boolean
        /// @param aRight if true will scroll right. if not will scroll left.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void ScrollCharacter([MarshalAs(UnmanagedType.U1)] bool right);
		
		/// <summary>
        ///SelectAll will select the whole page
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SelectAll();
		
		/// <summary>
        ///CheckVisibility will return true if textnode and offsets are actually rendered
        /// in the current precontext.
        /// @param aNode textNode to test
        /// @param aStartOffset  offset in dom to first char of textnode to test
        /// @param aEndOffset    offset in dom to last char of textnode to test
        /// @param aReturnBool   boolean returned TRUE if visible FALSE if not
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CheckVisibility([MarshalAs(UnmanagedType.Interface)] nsIDOMNode node, short startOffset, short endOffset);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool CheckVisibilityContent(System.IntPtr node, short startOffset, short endOffset);
	}
	
	/// <summary>nsISelectionControllerConsts </summary>
	public class nsISelectionControllerConsts
	{
		
		// <summary>
        //This Source Code Form is subject to the terms of the Mozilla Public
        // License, v. 2.0. If a copy of the MPL was not distributed with this
        // file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
		public const short SELECTION_NONE = 0;
		
		// 
		public const short SELECTION_NORMAL = 1;
		
		// 
		public const short SELECTION_SPELLCHECK = 2;
		
		// 
		public const short SELECTION_IME_RAWINPUT = 4;
		
		// 
		public const short SELECTION_IME_SELECTEDRAWTEXT = 8;
		
		// 
		public const short SELECTION_IME_CONVERTEDTEXT = 16;
		
		// 
		public const short SELECTION_IME_SELECTEDCONVERTEDTEXT = 32;
		
		// 
		public const short SELECTION_ACCESSIBILITY = 64;
		
		// <summary>
        // For accessibility API usage
        // </summary>
		public const short SELECTION_FIND = 128;
		
		// 
		public const short SELECTION_URLSECONDARY = 256;
		
		// 
		public const short NUM_SELECTIONTYPES = 10;
		
		// 
		public const short SELECTION_ANCHOR_REGION = 0;
		
		// 
		public const short SELECTION_FOCUS_REGION = 1;
		
		// 
		public const short SELECTION_WHOLE_SELECTION = 2;
		
		// 
		public const short NUM_SELECTION_REGIONS = 3;
		
		// 
		public const short SELECTION_OFF = 0;
		
		// 
		public const short SELECTION_HIDDEN = 1;
		
		// <summary>
        //>HIDDEN displays selection
        // </summary>
		public const short SELECTION_ON = 2;
		
		// 
		public const short SELECTION_DISABLED = 3;
		
		// 
		public const short SELECTION_ATTENTION = 4;
		
		// 
		public const short SCROLL_SYNCHRONOUS = 1<<1;
		
		// 
		public const short SCROLL_FIRST_ANCESTOR_ONLY = 1<<2;
		
		// 
		public const short SCROLL_CENTER_VERTICALLY = 1<<4;
		
		// 
		public const short SCROLL_OVERFLOW_HIDDEN = 1<<5;
	}
}
