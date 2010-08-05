//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by jni4net. See http://jni4net.sourceforge.net/ 
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace net.sf.robocode.peer {
    
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
    public partial interface IRobotPeer {
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void drainEnergy();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lnet/sf/robocode/peer/BadBehavior;)V")]
        void punishBadBehavior(global::net.sf.robocode.peer.BadBehavior par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Z)V")]
        void setRunning(bool par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()Z")]
        bool isRunning();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lnet/sf/robocode/peer/ExecCommands;)Lnet/sf/robocode/peer/ExecResults;")]
        global::java.lang.Object waitForBattleEndImpl(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Lnet/sf/robocode/peer/ExecCommands;)Lnet/sf/robocode/peer/ExecResults;")]
        global::java.lang.Object executeImpl(global::java.lang.Object par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("(Ljava/nio/ByteBuffer;)V")]
        void setupBuffer(global::java.nio.ByteBuffer par0);
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void executeImplSerial();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void waitForBattleEndImplSerial();
        
        [global::net.sf.jni4net.attributes.JavaMethodAttribute("()V")]
        void setupThread();
    }
    #endregion
    
    #region Component Designer generated code 
    public partial class IRobotPeer_ {
        
        public static global::java.lang.Class _class {
            get {
                return global::net.sf.robocode.peer.@__IRobotPeer.staticClass;
            }
        }
    }
    #endregion
    
    #region Component Designer generated code 
    [global::net.sf.jni4net.attributes.JavaProxyAttribute(typeof(global::net.sf.robocode.peer.IRobotPeer), typeof(global::net.sf.robocode.peer.IRobotPeer_))]
    [global::net.sf.jni4net.attributes.ClrWrapperAttribute(typeof(global::net.sf.robocode.peer.IRobotPeer), typeof(global::net.sf.robocode.peer.IRobotPeer_))]
    internal sealed partial class @__IRobotPeer : global::java.lang.Object, global::net.sf.robocode.peer.IRobotPeer {
        
        internal new static global::java.lang.Class staticClass;
        
        internal static global::net.sf.jni4net.jni.MethodId _drainEnergy0;
        
        internal static global::net.sf.jni4net.jni.MethodId _punishBadBehavior1;
        
        internal static global::net.sf.jni4net.jni.MethodId _setRunning2;
        
        internal static global::net.sf.jni4net.jni.MethodId _isRunning3;
        
        internal static global::net.sf.jni4net.jni.MethodId _waitForBattleEndImpl4;
        
        internal static global::net.sf.jni4net.jni.MethodId _executeImpl5;
        
        internal static global::net.sf.jni4net.jni.MethodId _setupBuffer6;
        
        internal static global::net.sf.jni4net.jni.MethodId _executeImplSerial7;
        
        internal static global::net.sf.jni4net.jni.MethodId _waitForBattleEndImplSerial8;
        
        internal static global::net.sf.jni4net.jni.MethodId _setupThread9;
        
        private @__IRobotPeer(global::net.sf.jni4net.jni.JNIEnv @__env) : 
                base(@__env) {
        }
        
        private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) {
            global::net.sf.robocode.peer.@__IRobotPeer.staticClass = @__class;
            global::net.sf.robocode.peer.@__IRobotPeer._drainEnergy0 = @__env.GetMethodID(global::net.sf.robocode.peer.@__IRobotPeer.staticClass, "drainEnergy", "()V");
            global::net.sf.robocode.peer.@__IRobotPeer._punishBadBehavior1 = @__env.GetMethodID(global::net.sf.robocode.peer.@__IRobotPeer.staticClass, "punishBadBehavior", "(Lnet/sf/robocode/peer/BadBehavior;)V");
            global::net.sf.robocode.peer.@__IRobotPeer._setRunning2 = @__env.GetMethodID(global::net.sf.robocode.peer.@__IRobotPeer.staticClass, "setRunning", "(Z)V");
            global::net.sf.robocode.peer.@__IRobotPeer._isRunning3 = @__env.GetMethodID(global::net.sf.robocode.peer.@__IRobotPeer.staticClass, "isRunning", "()Z");
            global::net.sf.robocode.peer.@__IRobotPeer._waitForBattleEndImpl4 = @__env.GetMethodID(global::net.sf.robocode.peer.@__IRobotPeer.staticClass, "waitForBattleEndImpl", "(Lnet/sf/robocode/peer/ExecCommands;)Lnet/sf/robocode/peer/ExecResults;");
            global::net.sf.robocode.peer.@__IRobotPeer._executeImpl5 = @__env.GetMethodID(global::net.sf.robocode.peer.@__IRobotPeer.staticClass, "executeImpl", "(Lnet/sf/robocode/peer/ExecCommands;)Lnet/sf/robocode/peer/ExecResults;");
            global::net.sf.robocode.peer.@__IRobotPeer._setupBuffer6 = @__env.GetMethodID(global::net.sf.robocode.peer.@__IRobotPeer.staticClass, "setupBuffer", "(Ljava/nio/ByteBuffer;)V");
            global::net.sf.robocode.peer.@__IRobotPeer._executeImplSerial7 = @__env.GetMethodID(global::net.sf.robocode.peer.@__IRobotPeer.staticClass, "executeImplSerial", "()V");
            global::net.sf.robocode.peer.@__IRobotPeer._waitForBattleEndImplSerial8 = @__env.GetMethodID(global::net.sf.robocode.peer.@__IRobotPeer.staticClass, "waitForBattleEndImplSerial", "()V");
            global::net.sf.robocode.peer.@__IRobotPeer._setupThread9 = @__env.GetMethodID(global::net.sf.robocode.peer.@__IRobotPeer.staticClass, "setupThread", "()V");
        }
        
        public void drainEnergy() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.robocode.peer.@__IRobotPeer._drainEnergy0);
        }
        
        public void punishBadBehavior(global::net.sf.robocode.peer.BadBehavior par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.robocode.peer.@__IRobotPeer._punishBadBehavior1, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        public void setRunning(bool par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.robocode.peer.@__IRobotPeer._setRunning2, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(par0));
        }
        
        public bool isRunning() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return ((bool)(@__env.CallBooleanMethod(this, global::net.sf.robocode.peer.@__IRobotPeer._isRunning3)));
        }
        
        public global::java.lang.Object waitForBattleEndImpl(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.robocode.peer.@__IRobotPeer._waitForBattleEndImpl4, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        public global::java.lang.Object executeImpl(global::java.lang.Object par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::net.sf.robocode.peer.@__IRobotPeer._executeImpl5, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0)));
        }
        
        public void setupBuffer(global::java.nio.ByteBuffer par0) {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.robocode.peer.@__IRobotPeer._setupBuffer6, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(par0));
        }
        
        public void executeImplSerial() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.robocode.peer.@__IRobotPeer._executeImplSerial7);
        }
        
        public void waitForBattleEndImplSerial() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.robocode.peer.@__IRobotPeer._waitForBattleEndImplSerial8);
        }
        
        public void setupThread() {
            global::net.sf.jni4net.jni.JNIEnv @__env = this.Env;
            @__env.CallVoidMethod(this, global::net.sf.robocode.peer.@__IRobotPeer._setupThread9);
        }
        
        private static global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> @__Init(global::net.sf.jni4net.jni.JNIEnv @__env, global::java.lang.Class @__class) {
            global::System.Type @__type = typeof(__IRobotPeer);
            global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod> methods = new global::System.Collections.Generic.List<global::net.sf.jni4net.jni.JNINativeMethod>();
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "drainEnergy", "drainEnergy0", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "punishBadBehavior", "punishBadBehavior1", "(Lnet/sf/robocode/peer/BadBehavior;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setRunning", "setRunning2", "(Z)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "isRunning", "isRunning3", "()Z"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "waitForBattleEndImpl", "waitForBattleEndImpl4", "(Lnet/sf/robocode/peer/ExecCommands;)Lnet/sf/robocode/peer/ExecResults;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "executeImpl", "executeImpl5", "(Lnet/sf/robocode/peer/ExecCommands;)Lnet/sf/robocode/peer/ExecResults;"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setupBuffer", "setupBuffer6", "(Ljava/nio/ByteBuffer;)V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "executeImplSerial", "executeImplSerial7", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "waitForBattleEndImplSerial", "waitForBattleEndImplSerial8", "()V"));
            methods.Add(global::net.sf.jni4net.jni.JNINativeMethod.Create(@__type, "setupThread", "setupThread9", "()V"));
            return methods;
        }
        
        private static void drainEnergy0(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.peer.IRobotPeer @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotPeer>(@__env, @__obj);
            @__real.drainEnergy();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void punishBadBehavior1(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lnet/sf/robocode/peer/BadBehavior;)V
            // (Lnet/sf/robocode/peer/BadBehavior;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.peer.IRobotPeer @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotPeer>(@__env, @__obj);
            @__real.punishBadBehavior(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::net.sf.robocode.peer.BadBehavior>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void setRunning2(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, bool par0) {
            // (Z)V
            // (Z)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.peer.IRobotPeer @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotPeer>(@__env, @__obj);
            @__real.setRunning(par0);
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static bool isRunning3(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()Z
            // ()Z
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            bool @__return = default(bool);
            try {
            global::net.sf.robocode.peer.IRobotPeer @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotPeer>(@__env, @__obj);
            @__return = ((bool)(@__real.isRunning()));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle waitForBattleEndImpl4(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lnet/sf/robocode/peer/ExecCommands;)Lnet/sf/robocode/peer/ExecResults;
            // (Ljava/lang/Object;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.robocode.peer.IRobotPeer @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotPeer>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.waitForBattleEndImpl(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static global::net.sf.jni4net.utils.JniHandle executeImpl5(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Lnet/sf/robocode/peer/ExecCommands;)Lnet/sf/robocode/peer/ExecResults;
            // (Ljava/lang/Object;)Ljava/lang/Object;
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            global::net.sf.jni4net.utils.JniHandle @__return = default(global::net.sf.jni4net.utils.JniHandle);
            try {
            global::net.sf.robocode.peer.IRobotPeer @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotPeer>(@__env, @__obj);
            @__return = global::net.sf.jni4net.utils.Convertor.StrongCp2J(@__real.executeImpl(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.lang.Object>(@__env, par0)));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
            return @__return;
        }
        
        private static void setupBuffer6(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj, global::net.sf.jni4net.utils.JniLocalHandle par0) {
            // (Ljava/nio/ByteBuffer;)V
            // (Ljava/nio/ByteBuffer;)V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.peer.IRobotPeer @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotPeer>(@__env, @__obj);
            @__real.setupBuffer(global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<global::java.nio.ByteBuffer>(@__env, par0));
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void executeImplSerial7(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.peer.IRobotPeer @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotPeer>(@__env, @__obj);
            @__real.executeImplSerial();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void waitForBattleEndImplSerial8(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.peer.IRobotPeer @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotPeer>(@__env, @__obj);
            @__real.waitForBattleEndImplSerial();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        private static void setupThread9(global::System.IntPtr @__envp, global::net.sf.jni4net.utils.JniLocalHandle @__obj) {
            // ()V
            // ()V
            global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.Wrap(@__envp);
            try {
            global::net.sf.robocode.peer.IRobotPeer @__real = global::net.sf.jni4net.utils.Convertor.FullJ2C<global::net.sf.robocode.peer.IRobotPeer>(@__env, @__obj);
            @__real.setupThread();
            }catch (global::System.Exception __ex){@__env.ThrowExisting(__ex);}
        }
        
        new internal sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper {
            
            public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) {
                return new global::net.sf.robocode.peer.@__IRobotPeer(@__env);
            }
        }
    }
    #endregion
}