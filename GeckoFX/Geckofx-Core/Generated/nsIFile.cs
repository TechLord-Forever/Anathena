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
// Generated by IDLImporter from file nsIFile.idl
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
    /// An nsIFile is an abstract representation of a filename. It manages
    /// filename encoding issues, pathname component separators ('/' vs. '\\'
    /// vs. ':') and weird stuff like differing volumes with identical names, as
    /// on pre-Darwin Macintoshes.
    ///
    /// This file has long introduced itself to new hackers with this opening
    /// paragraph:
    ///
    /// This is the only correct cross-platform way to specify a file.
    /// Strings are not such a way. If you grew up on windows or unix, you
    /// may think they are.  Welcome to reality.
    ///
    /// While taking the pose struck here to heart would be uncalled for, one
    /// may safely conclude that writing cross-platform code is an embittering
    /// experience.
    ///
    /// All methods with string parameters have two forms.  The preferred
    /// form operates on UCS-2 encoded characters strings.  An alternate
    /// form operates on characters strings encoded in the "native" charset.
    ///
    /// A string containing characters encoded in the native charset cannot
    /// be safely passed to javascript via xpconnect.  Therefore, the "native
    /// methods" are not scriptable.
    /// </summary>
    [ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a99a6a06-f90d-4659-8fce-c2f87feb1167")]
	public interface nsIFile
	{
		
		/// <summary>
        /// append[Native]
        ///
        /// This function is used for constructing a descendent of the
        /// current nsIFile.
        ///
        /// @param node
        /// A string which is intended to be a child node of the nsIFile.
        /// For the |appendNative| method, the node must be in the native
        /// filesystem charset.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase node);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendNative([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase node);
		
		/// <summary>
        /// Normalize the pathName (e.g. removing .. and . components on Unix).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Normalize();
		
		/// <summary>
        /// create
        ///
        /// This function will create a new file or directory in the
        /// file system. Any nodes that have not been created or
        /// resolved, will be.  If the file or directory already
        /// exists create() will return NS_ERROR_FILE_ALREADY_EXISTS.
        ///
        /// @param type
        /// This specifies the type of file system object
        /// to be made.  The only two types at this time
        /// are file and directory which are defined above.
        /// If the type is unrecongnized, we will return an
        /// error (NS_ERROR_FILE_UNKNOWN_TYPE).
        ///
        /// @param permissions
        /// The unix style octal permissions.  This may
        /// be ignored on systems that do not need to do
        /// permissions.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Create(uint type, uint permissions);
		
		/// <summary>
        /// Accessor to the leaf name of the file itself.
        /// For the |nativeLeafName| method, the nativeLeafName must
        /// be in the native filesystem charset.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetLeafNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLeafName);
		
		/// <summary>
        /// Accessor to the leaf name of the file itself.
        /// For the |nativeLeafName| method, the nativeLeafName must
        /// be in the native filesystem charset.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLeafNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNativeLeafNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNativeLeafName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetNativeLeafNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNativeLeafName);
		
		/// <summary>
        /// copyTo[Native]
        ///
        /// This will copy this file to the specified newParentDir.
        /// If a newName is specified, the file will be renamed.
        /// If 'this' is not created we will return an error
        /// (NS_ERROR_FILE_TARGET_DOES_NOT_EXIST).
        ///
        /// copyTo may fail if the file already exists in the destination
        /// directory.
        ///
        /// copyTo will NOT resolve aliases/shortcuts during the copy.
        ///
        /// @param newParentDir
        /// This param is the destination directory. If the
        /// newParentDir is null, copyTo() will use the parent
        /// directory of this file. If the newParentDir is not
        /// empty and is not a directory, an error will be
        /// returned (NS_ERROR_FILE_DESTINATION_NOT_DIR). For the
        /// |CopyToNative| method, the newName must be in the
        /// native filesystem charset.
        ///
        /// @param newName
        /// This param allows you to specify a new name for
        /// the file to be copied. This param may be empty, in
        /// which case the current leaf name will be used.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyTo([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyToNative([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase newName);
		
		/// <summary>
        /// copyToFollowingLinks[Native]
        ///
        /// This function is identical to copyTo with the exception that,
        /// as the name implies, it follows symbolic links.  The XP_UNIX
        /// implementation always follow symbolic links when copying.  For
        /// the |CopyToFollowingLinks| method, the newName must be in the
        /// native filesystem charset.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyToFollowingLinks([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CopyToFollowingLinksNative([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase newName);
		
		/// <summary>
        /// moveTo[Native]
        ///
        /// A method to move this file or directory to newParentDir.
        /// If a newName is specified, the file or directory will be renamed.
        /// If 'this' is not created we will return an error
        /// (NS_ERROR_FILE_TARGET_DOES_NOT_EXIST).
        /// If 'this' is a file, and the destination file already exists, moveTo
        /// will replace the old file.
        /// This object is updated to refer to the new file.
        ///
        /// moveTo will NOT resolve aliases/shortcuts during the copy.
        /// moveTo will do the right thing and allow copies across volumes.
        /// moveTo will return an error (NS_ERROR_FILE_DIR_NOT_EMPTY) if 'this' is
        /// a directory and the destination directory is not empty.
        /// moveTo will return an error (NS_ERROR_FILE_ACCESS_DENIED) if 'this' is
        /// a directory and the destination directory is not writable.
        ///
        /// @param newParentDir
        /// This param is the destination directory. If the
        /// newParentDir is empty, moveTo() will rename the file
        /// within its current directory. If the newParentDir is
        /// not empty and does not name a directory, an error will
        /// be returned (NS_ERROR_FILE_DESTINATION_NOT_DIR).  For
        /// the |moveToNative| method, the newName must be in the
        /// native filesystem charset.
        ///
        /// @param newName
        /// This param allows you to specify a new name for
        /// the file to be moved. This param may be empty, in
        /// which case the current leaf name will be used.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MoveTo([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newName);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void MoveToNative([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase newName);
		
		/// <summary>
        /// renameTo
        ///
        /// This method is identical to moveTo except that if this file or directory
        /// is moved to a a different volume, it fails and returns an error
        /// (NS_ERROR_FILE_ACCESS_DENIED).
        /// This object will still point to the old location after renaming.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void RenameTo([MarshalAs(UnmanagedType.Interface)] nsIFile newParentDir, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase newName);
		
		/// <summary>
        /// This will try to delete this file.  The 'recursive' flag
        /// must be PR_TRUE to delete directories which are not empty.
        ///
        /// This will not resolve any symlinks.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Remove([MarshalAs(UnmanagedType.U1)] bool recursive);
		
		/// <summary>
        /// Attributes of nsIFile.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetPermissionsAttribute();
		
		/// <summary>
        /// Attributes of nsIFile.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPermissionsAttribute(uint aPermissions);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetPermissionsOfLinkAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPermissionsOfLinkAttribute(uint aPermissionsOfLink);
		
		/// <summary>
        /// File Times are to be in milliseconds from
        /// midnight (00:00:00), January 1, 1970 Greenwich Mean
        /// Time (GMT).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetLastModifiedTimeAttribute();
		
		/// <summary>
        /// File Times are to be in milliseconds from
        /// midnight (00:00:00), January 1, 1970 Greenwich Mean
        /// Time (GMT).
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLastModifiedTimeAttribute(long aLastModifiedTime);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetLastModifiedTimeOfLinkAttribute();
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetLastModifiedTimeOfLinkAttribute(long aLastModifiedTimeOfLink);
		
		/// <summary>
        /// WARNING!  On the Mac, getting/setting the file size with nsIFile
        /// only deals with the size of the data fork.  If you need to
        /// know the size of the combined data and resource forks use the
        /// GetFileSizeWithResFork() method defined on nsILocalFileMac.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetFileSizeAttribute();
		
		/// <summary>
        /// WARNING!  On the Mac, getting/setting the file size with nsIFile
        /// only deals with the size of the data fork.  If you need to
        /// know the size of the combined data and resource forks use the
        /// GetFileSizeWithResFork() method defined on nsILocalFileMac.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFileSizeAttribute(long aFileSize);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetFileSizeOfLinkAttribute();
		
		/// <summary>
        /// target & path
        ///
        /// Accessor to the string path.  The native version of these
        /// strings are not guaranteed to be a usable path to pass to
        /// NSPR or the C stdlib.  There are problems that affect
        /// platforms on which a path does not fully specify a file
        /// because two volumes can have the same name (e.g., mac).
        /// This is solved by holding "private", native data in the
        /// nsIFile implementation.  This native data is lost when
        /// you convert to a string.
        ///
        /// DO NOT PASS TO USE WITH NSPR OR STDLIB!
        ///
        /// target
        /// Find out what the symlink points at.  Will give error
        /// (NS_ERROR_FILE_INVALID_PATH) if not a symlink.
        ///
        /// path
        /// Find out what the nsIFile points at.
        ///
        /// Note that the ACString attributes are returned in the
        /// native filesystem charset.
        ///
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTargetAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aTarget);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNativeTargetAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNativeTarget);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPathAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetNativePathAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aNativePath);
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Exists();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsWritable();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsReadable();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsExecutable();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsHidden();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsDirectory();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsFile();
		
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSymlink();
		
		/// <summary>
        /// Not a regular file, not a directory, not a symlink.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool IsSpecial();
		
		/// <summary>
        /// createUnique
        ///
        /// This function will create a new file or directory in the
        /// file system. Any nodes that have not been created or
        /// resolved, will be.  If this file already exists, we try
        /// variations on the leaf name "suggestedName" until we find
        /// one that did not already exist.
        ///
        /// If the search for nonexistent files takes too long
        /// (thousands of the variants already exist), we give up and
        /// return NS_ERROR_FILE_TOO_BIG.
        ///
        /// @param type
        /// This specifies the type of file system object
        /// to be made.  The only two types at this time
        /// are file and directory which are defined above.
        /// If the type is unrecongnized, we will return an
        /// error (NS_ERROR_FILE_UNKNOWN_TYPE).
        ///
        /// @param permissions
        /// The unix style octal permissions.  This may
        /// be ignored on systems that do not need to do
        /// permissions.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void CreateUnique(uint type, uint permissions);
		
		/// <summary>
        /// clone()
        ///
        /// This function will allocate and initialize a nsIFile object to the
        /// exact location of the |this| nsIFile.
        ///
        /// @param file
        /// A nsIFile which this object will be initialize
        /// with.
        ///
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile Clone();
		
		/// <summary>
        /// Will determine if the inFile equals this.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Equals([MarshalAs(UnmanagedType.Interface)] nsIFile inFile);
		
		/// <summary>
        /// Will determine if inFile is a descendant of this file
        /// If |recur| is true, look in subdirectories too
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool Contains([MarshalAs(UnmanagedType.Interface)] nsIFile inFile, [MarshalAs(UnmanagedType.U1)] bool recur);
		
		/// <summary>
        /// Parent will be null when this is at the top of the volume.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIFile GetParentAttribute();
		
		/// <summary>
        /// Returns an enumeration of the elements in a directory. Each
        /// element in the enumeration is an nsIFile.
        ///
        /// @throws NS_ERROR_FILE_NOT_DIRECTORY if the current nsIFile does
        /// not specify a directory.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsISimpleEnumerator GetDirectoryEntriesAttribute();
		
		/// <summary>
        /// initWith[Native]Path
        ///
        /// This function will initialize the nsIFile object.  Any
        /// internal state information will be reset.
        ///
        /// @param filePath
        /// A string which specifies a full file path to a
        /// location.  Relative paths will be treated as an
        /// error (NS_ERROR_FILE_UNRECOGNIZED_PATH).  For
        /// initWithNativePath, the filePath must be in the native
        /// filesystem charset.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWithPath([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase filePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWithNativePath([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase filePath);
		
		/// <summary>
        /// initWithFile
        ///
        /// Initialize this object with another file
        ///
        /// @param aFile
        /// the file this becomes equivalent to
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void InitWithFile([MarshalAs(UnmanagedType.Interface)] nsIFile aFile);
		
		/// <summary>
        /// followLinks
        ///
        /// This attribute will determine if the nsLocalFile will auto
        /// resolve symbolic links.  By default, this value will be false
        /// on all non unix systems.  On unix, this attribute is effectively
        /// a noop.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetFollowLinksAttribute();
		
		/// <summary>
        /// followLinks
        ///
        /// This attribute will determine if the nsLocalFile will auto
        /// resolve symbolic links.  By default, this value will be false
        /// on all non unix systems.  On unix, this attribute is effectively
        /// a noop.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFollowLinksAttribute([MarshalAs(UnmanagedType.U1)] bool aFollowLinks);
		
		/// <summary>
        /// Return the result of PR_Open on the file.  The caller is
        /// responsible for calling PR_Close on the result.
        ///
        /// @param flags the PR_Open flags from prio.h, plus optionally
        /// OS_READAHEAD or DELETE_ON_CLOSE. OS_READAHEAD is a hint to the
        /// OS that the file will be read sequentially with agressive
        /// readahead. DELETE_ON_CLOSE is unreliable on Windows and is deprecated.
        /// Instead use NS_OpenAnonymousTemporaryFile() to create a temporary
        /// file which will be deleted upon close.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr OpenNSPRFileDesc(int flags, int mode);
		
		/// <summary>
        /// Return the result of fopen on the file.  The caller is
        /// responsible for calling fclose on the result.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr OpenANSIFileDesc([MarshalAs(UnmanagedType.LPStr)] string mode);
		
		/// <summary>
        /// Return the result of PR_LoadLibrary on the file.  The caller is
        /// responsible for calling PR_UnloadLibrary on the result.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		System.IntPtr Load();
		
		/// <summary>
        /// number of bytes available on disk to non-superuser
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		long GetDiskSpaceAvailableAttribute();
		
		/// <summary>
        /// appendRelative[Native]Path
        ///
        /// Append a relative path to the current path of the nsIFile object.
        ///
        /// @param relativeFilePath
        /// relativeFilePath is a native relative path. For security reasons,
        /// this cannot contain .. or cannot start with a directory separator.
        /// For the |appendRelativeNativePath| method, the relativeFilePath
        /// must be in the native filesystem charset.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendRelativePath([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase relativeFilePath);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void AppendRelativeNativePath([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase relativeFilePath);
		
		/// <summary>
        /// Accessor to a null terminated string which will specify
        /// the file in a persistent manner for disk storage.
        ///
        /// The character set of this attribute is undefined.  DO NOT TRY TO
        /// INTERPRET IT AS HUMAN READABLE TEXT!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetPersistentDescriptorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPersistentDescriptor);
		
		/// <summary>
        /// Accessor to a null terminated string which will specify
        /// the file in a persistent manner for disk storage.
        ///
        /// The character set of this attribute is undefined.  DO NOT TRY TO
        /// INTERPRET IT AS HUMAN READABLE TEXT!
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetPersistentDescriptorAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aPersistentDescriptor);
		
		/// <summary>
        /// reveal
        ///
        /// Ask the operating system to open the folder which contains
        /// this file or folder. This routine only works on platforms which
        /// support the ability to open a folder and is run async on Windows.
        /// This routine must be called on the main.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Reveal();
		
		/// <summary>
        /// launch
        ///
        /// Ask the operating system to attempt to open the file.
        /// this really just simulates "double clicking" the file on your platform.
        /// This routine only works on platforms which support this functionality
        /// and is run async on Windows.  This routine must be called on the
        /// main thread.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Launch();
		
		/// <summary>
        /// getRelativeDescriptor
        ///
        /// Returns a relative file path in an opaque, XP format. It is therefore
        /// not a native path.
        ///
        /// The character set of the string returned from this function is
        /// undefined.  DO NOT TRY TO INTERPRET IT AS HUMAN READABLE TEXT!
        ///
        /// @param fromFile
        /// the file from which the descriptor is relative.
        /// There is no defined result if this param is null.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetRelativeDescriptor([MarshalAs(UnmanagedType.Interface)] nsIFile fromFile, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase retval);
		
		/// <summary>
        /// setRelativeDescriptor
        ///
        /// Initializes the file to the location relative to fromFile using
        /// a string returned by getRelativeDescriptor.
        ///
        /// @param fromFile
        /// the file to which the descriptor is relative
        /// @param relative
        /// the relative descriptor obtained from getRelativeDescriptor
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetRelativeDescriptor([MarshalAs(UnmanagedType.Interface)] nsIFile fromFile, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase relativeDesc);
	}
	
	/// <summary>nsIFileConsts </summary>
	public class nsIFileConsts
	{
		
		// <summary>
        // Create Types
        //
        // NORMAL_FILE_TYPE - A normal file.
        // DIRECTORY_TYPE   - A directory/folder.
        // </summary>
		public const ulong NORMAL_FILE_TYPE = 0;
		
		// 
		public const ulong DIRECTORY_TYPE = 1;
		
		// <summary>
        // Flag for openNSPRFileDesc(), to hint to the OS that the file will be
        // read sequentially with agressive readahead.
        // </summary>
		public const ulong OS_READAHEAD = 0x40000000;
		
		// <summary>
        // Flag for openNSPRFileDesc(). Deprecated and unreliable!
        // Instead use NS_OpenAnonymousTemporaryFile() to create a temporary
        // file which will be deleted upon close!
        // </summary>
		public const ulong DELETE_ON_CLOSE = 0x80000000;
	}
}
