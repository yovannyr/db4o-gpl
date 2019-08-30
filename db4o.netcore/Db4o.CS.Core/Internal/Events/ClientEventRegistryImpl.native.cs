///* Copyright (C) 2008   Versant Inc.   http://www.db4o.com */

//using System;
//using Db4o.Events;

//namespace Db4o.CS.Internal.Events
//{
//  public partial class ClientEventRegistryImpl
//    {
//        public override event System.EventHandler<ObjectInfoEventArgs> Deleted
//        {
//            add
//            {
//                throw new ArgumentException("delete() event is raised only at server side.");
//            }

//            remove
//            {
//                throw new ArgumentException("delete() event is raised only at server side.");
//            }
//        }

//        public override event System.EventHandler<CancellableObjectEventArgs> Deleting
//        {
//            add
//            {
//                throw new ArgumentException("deleting() event is raised only at server side.");
//            }

//            remove
//            {
//                throw new ArgumentException("deleting() event is raised only at server side.");
//            }
//        }
//    }
//}
