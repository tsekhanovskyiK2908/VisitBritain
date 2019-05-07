using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class LinksHolder
    {
        public Link Content = new Link()
        {
            LinkText = "Go to content",
            ActionName = "Content",
            ControllerName = "Home"
        };

        public Link Overview = new Link()
        {
            LinkText = "Go to overview",
            ActionName = "Overview",
            ControllerName = "Home"
        };

        public Link Main = new Link()
        {
            LinkText = "Back to main",
            ActionName = "Index",
            ControllerName = "Home"
        };

        public Link Chapter1 = new Link()
        {
            LinkText = "Chapter 1",
            ActionName = "Index",
            ControllerName = "Chapter1"
        };

        public Link InboundMarketStatistics = new Link()
        {
            LinkText = "Inbound Market Statistics",
            ActionName = "InboundMarketStatistics",
            ControllerName = "Chapter1"
        };

        public Link KeyInsights = new Link()
        {
            LinkText = "Key Insights",
            ActionName = "KeyInsights1",
            ControllerName = "Chapter1"
        };

        public Link Chapter2 = new Link()
        {
            LinkText = "Next chapter",
            ActionName = "Index",
            ControllerName = "Chapter2"
        };

        public Link Chapter3 = new Link()
        {
            LinkText = "Next chapter",
            ActionName = "Index",
            ControllerName = "Chapter3"
        };
    }
}