MultipleInjection

Samurai takes an array of weapons instead of a single weapon.  Because there are multiple bind<> statements in the Module.Load method, a Samurai with a constructor for a single object will throw an exception.