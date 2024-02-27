﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest73
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest73Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("f383a4c3-1cc1-4120-a314-25579dd95e73")]
    public partial class MyTest73Repository : RepoGenBaseFolder
    {
        static MyTest73Repository instance = new MyTest73Repository();
        MyTest73RepositoryFolders.RxMainFrameAppFolder _rxmainframe;

        /// <summary>
        /// Gets the singleton class instance representing the MyTest73Repository element repository.
        /// </summary>
        [RepositoryFolder("f383a4c3-1cc1-4120-a314-25579dd95e73")]
        public static MyTest73Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest73Repository() 
            : base("MyTest73Repository", "/", null, 0, false, "f383a4c3-1cc1-4120-a314-25579dd95e73", ".\\RepositoryImages\\MyTest73Repositoryf383a4c3.rximgres")
        {
            _rxmainframe = new MyTest73RepositoryFolders.RxMainFrameAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("f383a4c3-1cc1-4120-a314-25579dd95e73")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("7e77cbd2-8793-49dd-aa31-7900137fac28")]
        public virtual MyTest73RepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest73RepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("7e77cbd2-8793-49dd-aa31-7900137fac28")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _txtusernameInfo;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@controlname='RxMainFrame']", parentFolder, 30000, null, true, "7e77cbd2-8793-49dd-aa31-7900137fac28", "")
            {
                _txtusernameInfo = new RepoItemInfo(this, "TxtUserName", "?/?/tabpage[@controlname='RxTabIntroduction']/text[@controlname='txtUserName']", ".//text[@controlname='txtUserName']", 30000, null, "af4483a8-d9c2-4dbe-ba08-088721eb2071");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("7e77cbd2-8793-49dd-aa31-7900137fac28")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("7e77cbd2-8793-49dd-aa31-7900137fac28")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The TxtUserName item.
            /// </summary>
            [RepositoryItem("af4483a8-d9c2-4dbe-ba08-088721eb2071")]
            public virtual Ranorex.Text TxtUserName
            {
                get
                {
                    return _txtusernameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The TxtUserName item info.
            /// </summary>
            [RepositoryItemInfo("af4483a8-d9c2-4dbe-ba08-088721eb2071")]
            public virtual RepoItemInfo TxtUserNameInfo
            {
                get
                {
                    return _txtusernameInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
