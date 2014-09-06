﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

//Write a program to traverse given directory and write to a XML file its contents together with all subdirectories and files. 
//Use tags <file> and <dir> with appropriate attributes. 
//For the generation of the XML document use the class XmlWriter.

namespace DirectoryStructureToXML
{
    class MainLoader
    {
        static void Main(string[] args)
        {
            XmlTextWriter writer = new XmlTextWriter("../../../directory.xml", Encoding.UTF8);
            DirectoryInfo sourceDir = new DirectoryInfo("../../../");
            using (writer)
            {
                writer.WriteStartDocument();
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
                writer.WriteStartElement("directories");
                BuildXml(writer, sourceDir);
                writer.WriteEndDocument();
            }
        }
        private static void BuildXml(XmlTextWriter writer, DirectoryInfo sourceDir)
        {
            if (sourceDir.GetFiles().Count() == 0 && sourceDir.GetDirectories().Count() == 0)
            {
                return;
            }
            writer.WriteStartElement("directory");
            writer.WriteAttributeString("name", sourceDir.Name);
            foreach (var file in sourceDir.GetFiles())
            {
                writer.WriteElementString("file", file.Name);
            }
            foreach (var subDir in sourceDir.GetDirectories())
            {
                BuildXml(writer, subDir);
            }
            writer.WriteEndElement();
        }
    }
}