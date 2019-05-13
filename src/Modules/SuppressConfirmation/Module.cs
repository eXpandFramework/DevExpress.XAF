﻿using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.SystemModule;
using Xpand.XAF.Modules.Reactive;

namespace Xpand.XAF.Modules.SuppressConfirmation{
    public sealed class SuppressConfirmationModule : ModuleBase{
        public const string CategoryName = "Xpand.XAF.Modules.SupressConfirmation";

        public SuppressConfirmationModule(){
            RequiredModuleTypes.Add(typeof(SystemModule));
            RequiredModuleTypes.Add(typeof(ReactiveModule));   
            
        }

        public override void Setup(ApplicationModulesManager moduleManager){
            base.Setup(moduleManager);
            SuppressConfirmationService.Connect()
                .Subscribe();
        }

        public override void ExtendModelInterfaces(ModelInterfaceExtenders extenders){
            base.ExtendModelInterfaces(extenders);
            extenders.Add<IModelClass, IModelClassSupressConfirmation>();
            extenders.Add<IModelObjectView, IModelObjectViewSupressConfirmation>();
            
        }

    }
}