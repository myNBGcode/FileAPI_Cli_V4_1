﻿using CommandLine;
using System;

namespace FileapiCli.ConfigOptions
{
    [Verb("downloadfilesincoming", HelpText = "Downloads incomings files for user (both historical and non historical).")]
    public class DownloadFilesIncomingOptions : IOptions
    {
        [Option('f', "datefrom", HelpText = "Starting date (yyyy-mm-dd) of the time period files are retrieved from. Required")]
        public DateTime? DateFrom { get; set; }
        [Option('t', "dateto", HelpText = "End date (yyyy-mm-dd) of the time period files are retrieved from. Will fetch up to latest if ommited", Default = null)]
        public DateTime? DateTo { get; set; }
        [Option('d', "downloadfolder", HelpText = "Download location path for the files. Omit to use the current path.", Required = false)]
        public string DownloadFolder { get; set; }
        [Option('h', "isHistorical", HelpText = " Is historical file flag. If not defined returns both historical and non histrorical.")]
        public bool? IsHistorical { get; set; }
        [Option('m', "maxItems",  HelpText = "Max number of items to be downloaded. Required")]
        public int? MaxItems { get; set; }
    }
}
