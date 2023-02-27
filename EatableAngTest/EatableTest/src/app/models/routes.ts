import { EnvironmentProviders, Provider, Type } from "@angular/core"
import { CanActivateChildFn, CanActivateFn, CanDeactivateFn, CanLoadFn, CanMatchFn, Data, DefaultExport, LoadChildren, Resolve, ResolveData, ResolveFn, RunGuardsAndResolvers, UrlMatcher } from "@angular/router"
import { Observable } from "rxjs"

export interface Routes {
    title?: string | Type<Resolve<string>> | ResolveFn<string>
    path?: string
    pathMatch?: 'prefix' | 'full'
    matcher?: UrlMatcher
    component?: Type<any>
    loadComponent?: () => Type<unknown> | Observable<Type<unknown> | DefaultExport<Type<unknown>>> | Promise<Type<unknown> | DefaultExport<Type<unknown>>>
    redirectTo?: string
    outlet?: string
    canActivate?: Array<CanActivateFn>
    canMatch?: Array<CanMatchFn>
    canActivateChild?: Array<CanActivateChildFn>
    canDeactivate?: Array<CanDeactivateFn<any>>
    canLoad?: Array<CanLoadFn>
    data?: Data
    resolve?: ResolveData
    children?: Routes
    loadChildren?: LoadChildren
    runGuardsAndResolvers?: RunGuardsAndResolvers
    providers?: Array<Provider | EnvironmentProviders>
  }