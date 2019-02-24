// <copyright file="FormData.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace Mvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// FormData is a class for storing all elements after form submiting.
    /// </summary>
    public class FormData
    {
        /// <summary>
        /// Gets or sets FormGuid store the form identificator.
        /// </summary>
        public Guid FormGuid { get; set; }

        /// <summary>
        /// Gets or sets FormName store the name of forms.
        /// </summary>
        public string FormName { get; set; }

        /// <summary>
        /// Gets or sets FormDescr store the description of forms.
        /// </summary>
        public string FormDescr { get; set; }

        /// <summary>
        /// Gets or sets Field_name store names of created form blocks.
        /// </summary>
        public string[] Field_name { get; set; }

        /// <summary>
        /// Gets or sets Select store values of selected block types.
        /// </summary>
        public string[] Select { get; set; }

        /// <summary>
        /// Gets or sets Context contain block's input info.
        /// </summary>
        public string[] Context { get; set; }

        /// <summary>
        /// Gets or sets Check store info if the blocks are required.
        /// </summary>
        public string[] Check { get; set; }

        /*    /// <summary>
            /// Gets or sets Block store the blocks info.
            /// </summary>
            public Block[] Blocks { get; set; }
        }

        /// <summary>
        /// Block is a class for storing block info after form submiting.
        /// </summary>
        public class Block
        {
            /// <summary>
            /// Gets or sets Field_name store names of created form blocks.
            /// </summary>
            public string Field_name { get; set; }

            /// <summary>
            /// Gets or sets Select store values of selected block types.
            /// </summary>
            public string Select { get; set; }

            /// <summary>
            /// Gets or sets Context contain block's input info.
            /// </summary>
            public string Context { get; set; }

            /// <summary>
            /// Gets or sets Check store info if the blocks are required.
            /// </summary>
            public string Check { get; set; }
        }*/
    }
}