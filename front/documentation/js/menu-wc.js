'use strict';

customElements.define('compodoc-menu', class extends HTMLElement {
    constructor() {
        super();
        this.isNormalMode = this.getAttribute('mode') === 'normal';
    }

    connectedCallback() {
        this.render(this.isNormalMode);
    }

    render(isNormalMode) {
        let tp = lithtml.html(`
        <nav>
            <ul class="list">
                <li class="title">
                    <a href="index.html" data-type="index-link">fv documentation</a>
                </li>

                <li class="divider"></li>
                ${ isNormalMode ? `<div id="book-search-input" role="search"><input type="text" placeholder="Type to search"></div>` : '' }
                <li class="chapter">
                    <a data-type="chapter-link" href="index.html"><span class="icon ion-ios-home"></span>Getting started</a>
                    <ul class="links">
                        <li class="link">
                            <a href="overview.html" data-type="chapter-link">
                                <span class="icon ion-ios-keypad"></span>Overview
                            </a>
                        </li>
                        <li class="link">
                            <a href="index.html" data-type="chapter-link">
                                <span class="icon ion-ios-paper"></span>README
                            </a>
                        </li>
                                <li class="link">
                                    <a href="dependencies.html" data-type="chapter-link">
                                        <span class="icon ion-ios-list"></span>Dependencies
                                    </a>
                                </li>
                    </ul>
                </li>
                    <li class="chapter modules">
                        <a data-type="chapter-link" href="modules.html">
                            <div class="menu-toggler linked" data-toggle="collapse" ${ isNormalMode ?
                                'data-target="#modules-links"' : 'data-target="#xs-modules-links"' }>
                                <span class="icon ion-ios-archive"></span>
                                <span class="link-name">Modules</span>
                                <span class="icon ion-ios-arrow-down"></span>
                            </div>
                        </a>
                        <ul class="links collapse " ${ isNormalMode ? 'id="modules-links"' : 'id="xs-modules-links"' }>
                            <li class="link">
                                <a href="modules/AppModule.html" data-type="entity-link" >AppModule</a>
                                    <li class="chapter inner">
                                        <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ?
                                            'data-target="#components-links-module-AppModule-535cd530554b08a959703951392900ca0d7ca6b65703be5e664638cdcdb4a995ce74cc635642abd63792e9c46236fee58a1a9cca5d1b9d8c01327111c38bb74a"' : 'data-target="#xs-components-links-module-AppModule-535cd530554b08a959703951392900ca0d7ca6b65703be5e664638cdcdb4a995ce74cc635642abd63792e9c46236fee58a1a9cca5d1b9d8c01327111c38bb74a"' }>
                                            <span class="icon ion-md-cog"></span>
                                            <span>Components</span>
                                            <span class="icon ion-ios-arrow-down"></span>
                                        </div>
                                        <ul class="links collapse" ${ isNormalMode ? 'id="components-links-module-AppModule-535cd530554b08a959703951392900ca0d7ca6b65703be5e664638cdcdb4a995ce74cc635642abd63792e9c46236fee58a1a9cca5d1b9d8c01327111c38bb74a"' :
                                            'id="xs-components-links-module-AppModule-535cd530554b08a959703951392900ca0d7ca6b65703be5e664638cdcdb4a995ce74cc635642abd63792e9c46236fee58a1a9cca5d1b9d8c01327111c38bb74a"' }>
                                            <li class="link">
                                                <a href="components/AppComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >AppComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/MainSidebarContainerComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >MainSidebarContainerComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/NavBarComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >NavBarComponent</a>
                                            </li>
                                        </ul>
                                    </li>
                            </li>
                            <li class="link">
                                <a href="modules/AppRoutingModule.html" data-type="entity-link" >AppRoutingModule</a>
                            </li>
                            <li class="link">
                                <a href="modules/HomeModule.html" data-type="entity-link" >HomeModule</a>
                                    <li class="chapter inner">
                                        <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ?
                                            'data-target="#components-links-module-HomeModule-404afd5d1ed497e8a7b655244b8e7fe081f6c4bb990315d137e51d183138542feef14a13fee5ebab2ee7565927c17ab74dea3474e5695f16cb4c488603721465"' : 'data-target="#xs-components-links-module-HomeModule-404afd5d1ed497e8a7b655244b8e7fe081f6c4bb990315d137e51d183138542feef14a13fee5ebab2ee7565927c17ab74dea3474e5695f16cb4c488603721465"' }>
                                            <span class="icon ion-md-cog"></span>
                                            <span>Components</span>
                                            <span class="icon ion-ios-arrow-down"></span>
                                        </div>
                                        <ul class="links collapse" ${ isNormalMode ? 'id="components-links-module-HomeModule-404afd5d1ed497e8a7b655244b8e7fe081f6c4bb990315d137e51d183138542feef14a13fee5ebab2ee7565927c17ab74dea3474e5695f16cb4c488603721465"' :
                                            'id="xs-components-links-module-HomeModule-404afd5d1ed497e8a7b655244b8e7fe081f6c4bb990315d137e51d183138542feef14a13fee5ebab2ee7565927c17ab74dea3474e5695f16cb4c488603721465"' }>
                                            <li class="link">
                                                <a href="components/HeaderPlotComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >HeaderPlotComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/HomePageComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >HomePageComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/NotificationPlotComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >NotificationPlotComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/SalesPlotComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >SalesPlotComponent</a>
                                            </li>
                                        </ul>
                                    </li>
                            </li>
                            <li class="link">
                                <a href="modules/HomeRoutingModule.html" data-type="entity-link" >HomeRoutingModule</a>
                            </li>
                            <li class="link">
                                <a href="modules/LoginModule.html" data-type="entity-link" >LoginModule</a>
                                    <li class="chapter inner">
                                        <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ?
                                            'data-target="#components-links-module-LoginModule-172cd04c2a49cce851c63edaea7fe2d9c55691d50c7a5016b58e6fcb82a75d28829d58d8a3826e83f4bd7224c5dcb7d6a990719540d179816a7f5538c5904d16"' : 'data-target="#xs-components-links-module-LoginModule-172cd04c2a49cce851c63edaea7fe2d9c55691d50c7a5016b58e6fcb82a75d28829d58d8a3826e83f4bd7224c5dcb7d6a990719540d179816a7f5538c5904d16"' }>
                                            <span class="icon ion-md-cog"></span>
                                            <span>Components</span>
                                            <span class="icon ion-ios-arrow-down"></span>
                                        </div>
                                        <ul class="links collapse" ${ isNormalMode ? 'id="components-links-module-LoginModule-172cd04c2a49cce851c63edaea7fe2d9c55691d50c7a5016b58e6fcb82a75d28829d58d8a3826e83f4bd7224c5dcb7d6a990719540d179816a7f5538c5904d16"' :
                                            'id="xs-components-links-module-LoginModule-172cd04c2a49cce851c63edaea7fe2d9c55691d50c7a5016b58e6fcb82a75d28829d58d8a3826e83f4bd7224c5dcb7d6a990719540d179816a7f5538c5904d16"' }>
                                            <li class="link">
                                                <a href="components/EmailCheckComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >EmailCheckComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/LoginMenuComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >LoginMenuComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/LoginPageComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >LoginPageComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/RefactorPasswordComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >RefactorPasswordComponent</a>
                                            </li>
                                        </ul>
                                    </li>
                            </li>
                            <li class="link">
                                <a href="modules/LoginRoutingModule.html" data-type="entity-link" >LoginRoutingModule</a>
                            </li>
                            <li class="link">
                                <a href="modules/RepresentanteModule.html" data-type="entity-link" >RepresentanteModule</a>
                                    <li class="chapter inner">
                                        <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ?
                                            'data-target="#components-links-module-RepresentanteModule-215acaf629d07b710f06600baedcf8b10f2ebbdab018d6d64072050e347e77a05d09afa665efdce7e2b5012ee3af6392d1cce36ed51a1c34c6e941f228e94b02"' : 'data-target="#xs-components-links-module-RepresentanteModule-215acaf629d07b710f06600baedcf8b10f2ebbdab018d6d64072050e347e77a05d09afa665efdce7e2b5012ee3af6392d1cce36ed51a1c34c6e941f228e94b02"' }>
                                            <span class="icon ion-md-cog"></span>
                                            <span>Components</span>
                                            <span class="icon ion-ios-arrow-down"></span>
                                        </div>
                                        <ul class="links collapse" ${ isNormalMode ? 'id="components-links-module-RepresentanteModule-215acaf629d07b710f06600baedcf8b10f2ebbdab018d6d64072050e347e77a05d09afa665efdce7e2b5012ee3af6392d1cce36ed51a1c34c6e941f228e94b02"' :
                                            'id="xs-components-links-module-RepresentanteModule-215acaf629d07b710f06600baedcf8b10f2ebbdab018d6d64072050e347e77a05d09afa665efdce7e2b5012ee3af6392d1cce36ed51a1c34c6e941f228e94b02"' }>
                                            <li class="link">
                                                <a href="components/AnexoComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >AnexoComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/AutorizacaoretiradaComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >AutorizacaoretiradaComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/BookComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >BookComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/ClientComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >ClientComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/ClientGridComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >ClientGridComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/ClientPerfilComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >ClientPerfilComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/Client_detailsComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >Client_detailsComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/ClientesComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >ClientesComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/ComissaoComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >ComissaoComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/DetailEstoqueComponentComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >DetailEstoqueComponentComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/DinamicFilterComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >DinamicFilterComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/EstoqueComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >EstoqueComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/EstoqueContentComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >EstoqueContentComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/EstoqueGridComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >EstoqueGridComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/FinanceiroComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >FinanceiroComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/FinanceiroGridComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >FinanceiroGridComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/GeralComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >GeralComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/GridClientPerfilComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >GridClientPerfilComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/GridNotaFiscalComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >GridNotaFiscalComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/GridSolicitacaoDevolucaoComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >GridSolicitacaoDevolucaoComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/IniciorepresentanteComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >IniciorepresentanteComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/Min_loadingComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >Min_loadingComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/NotaFiscalComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >NotaFiscalComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/PedidoandamentoComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >PedidoandamentoComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/PedidosComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >PedidosComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/ProgramadosComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >ProgramadosComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/ReportEstoqueComponentComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >ReportEstoqueComponentComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/SacComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >SacComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/SolicitacaoDevolucaoComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >SolicitacaoDevolucaoComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/TabprecoComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >TabprecoComponent</a>
                                            </li>
                                        </ul>
                                    </li>
                            </li>
                            <li class="link">
                                <a href="modules/RepresentanteRoutingModule.html" data-type="entity-link" >RepresentanteRoutingModule</a>
                            </li>
                            <li class="link">
                                <a href="modules/SegurancaModule.html" data-type="entity-link" >SegurancaModule</a>
                                    <li class="chapter inner">
                                        <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ?
                                            'data-target="#components-links-module-SegurancaModule-a75baa92c2a0c3f45c55549a3dc1d2b60b220ce97e3774b3644854065e0c9b17aa6b85479a7706763c0d3a0bcbae9b07545dc06d88fac0624d931750eaefc25e"' : 'data-target="#xs-components-links-module-SegurancaModule-a75baa92c2a0c3f45c55549a3dc1d2b60b220ce97e3774b3644854065e0c9b17aa6b85479a7706763c0d3a0bcbae9b07545dc06d88fac0624d931750eaefc25e"' }>
                                            <span class="icon ion-md-cog"></span>
                                            <span>Components</span>
                                            <span class="icon ion-ios-arrow-down"></span>
                                        </div>
                                        <ul class="links collapse" ${ isNormalMode ? 'id="components-links-module-SegurancaModule-a75baa92c2a0c3f45c55549a3dc1d2b60b220ce97e3774b3644854065e0c9b17aa6b85479a7706763c0d3a0bcbae9b07545dc06d88fac0624d931750eaefc25e"' :
                                            'id="xs-components-links-module-SegurancaModule-a75baa92c2a0c3f45c55549a3dc1d2b60b220ce97e3774b3644854065e0c9b17aa6b85479a7706763c0d3a0bcbae9b07545dc06d88fac0624d931750eaefc25e"' }>
                                            <li class="link">
                                                <a href="components/DiretorioComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >DiretorioComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/DiretorioContentComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >DiretorioContentComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/DiretorioGridComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >DiretorioGridComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/EmpresaComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >EmpresaComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/EmpresaContentComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >EmpresaContentComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/EmpresaGridComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >EmpresaGridComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/ParametroComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >ParametroComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/ParametroContentComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >ParametroContentComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/ParametroGridComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >ParametroGridComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/PerfilComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >PerfilComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/PerfilContentComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >PerfilContentComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/PerfilGridComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >PerfilGridComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/TelaComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >TelaComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/TelaContentComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >TelaContentComponent</a>
                                            </li>
                                            <li class="link">
                                                <a href="components/TelaGridComponent.html" data-type="entity-link" data-context="sub-entity" data-context-id="modules" >TelaGridComponent</a>
                                            </li>
                                        </ul>
                                    </li>
                            </li>
                            <li class="link">
                                <a href="modules/SegurancaRoutingModule.html" data-type="entity-link" >SegurancaRoutingModule</a>
                            </li>
                </ul>
                </li>
                    <li class="chapter">
                        <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ? 'data-target="#components-links"' :
                            'data-target="#xs-components-links"' }>
                            <span class="icon ion-md-cog"></span>
                            <span>Components</span>
                            <span class="icon ion-ios-arrow-down"></span>
                        </div>
                        <ul class="links collapse " ${ isNormalMode ? 'id="components-links"' : 'id="xs-components-links"' }>
                            <li class="link">
                                <a href="components/EditDiretorioComponentComponent.html" data-type="entity-link" >EditDiretorioComponentComponent</a>
                            </li>
                            <li class="link">
                                <a href="components/EditEmpresaComponentComponent.html" data-type="entity-link" >EditEmpresaComponentComponent</a>
                            </li>
                            <li class="link">
                                <a href="components/EditParametroComponentComponent.html" data-type="entity-link" >EditParametroComponentComponent</a>
                            </li>
                            <li class="link">
                                <a href="components/EditPerfilComponentComponent.html" data-type="entity-link" >EditPerfilComponentComponent</a>
                            </li>
                            <li class="link">
                                <a href="components/EditTelaComponentComponent.html" data-type="entity-link" >EditTelaComponentComponent</a>
                            </li>
                            <li class="link">
                                <a href="components/EditUsuarioComponentComponent.html" data-type="entity-link" >EditUsuarioComponentComponent</a>
                            </li>
                            <li class="link">
                                <a href="components/UsuarioComponent.html" data-type="entity-link" >UsuarioComponent</a>
                            </li>
                            <li class="link">
                                <a href="components/UsuarioContentComponent.html" data-type="entity-link" >UsuarioContentComponent</a>
                            </li>
                            <li class="link">
                                <a href="components/UsuarioGridComponent.html" data-type="entity-link" >UsuarioGridComponent</a>
                            </li>
                        </ul>
                    </li>
                    <li class="chapter">
                        <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ? 'data-target="#classes-links"' :
                            'data-target="#xs-classes-links"' }>
                            <span class="icon ion-ios-paper"></span>
                            <span>Classes</span>
                            <span class="icon ion-ios-arrow-down"></span>
                        </div>
                        <ul class="links collapse " ${ isNormalMode ? 'id="classes-links"' : 'id="xs-classes-links"' }>
                            <li class="link">
                                <a href="classes/AsideMenu.html" data-type="entity-link" >AsideMenu</a>
                            </li>
                            <li class="link">
                                <a href="classes/ClientTabs.html" data-type="entity-link" >ClientTabs</a>
                            </li>
                            <li class="link">
                                <a href="classes/Convert.html" data-type="entity-link" >Convert</a>
                            </li>
                            <li class="link">
                                <a href="classes/EditDiretorioWords.html" data-type="entity-link" >EditDiretorioWords</a>
                            </li>
                            <li class="link">
                                <a href="classes/EditEmpresaWords.html" data-type="entity-link" >EditEmpresaWords</a>
                            </li>
                            <li class="link">
                                <a href="classes/EditParametroWords.html" data-type="entity-link" >EditParametroWords</a>
                            </li>
                            <li class="link">
                                <a href="classes/EditPerfilWords.html" data-type="entity-link" >EditPerfilWords</a>
                            </li>
                            <li class="link">
                                <a href="classes/EditTelaWords.html" data-type="entity-link" >EditTelaWords</a>
                            </li>
                            <li class="link">
                                <a href="classes/EditUsuarioWords.html" data-type="entity-link" >EditUsuarioWords</a>
                            </li>
                            <li class="link">
                                <a href="classes/EstoqueSearch.html" data-type="entity-link" >EstoqueSearch</a>
                            </li>
                            <li class="link">
                                <a href="classes/Grid.html" data-type="entity-link" >Grid</a>
                            </li>
                            <li class="link">
                                <a href="classes/ILogin.html" data-type="entity-link" >ILogin</a>
                            </li>
                            <li class="link">
                                <a href="classes/Paginate.html" data-type="entity-link" >Paginate</a>
                            </li>
                            <li class="link">
                                <a href="classes/PaginateShare.html" data-type="entity-link" >PaginateShare</a>
                            </li>
                            <li class="link">
                                <a href="classes/Route.html" data-type="entity-link" >Route</a>
                            </li>
                            <li class="link">
                                <a href="classes/Route-1.html" data-type="entity-link" >Route</a>
                            </li>
                            <li class="link">
                                <a href="classes/Route-2.html" data-type="entity-link" >Route</a>
                            </li>
                            <li class="link">
                                <a href="classes/Route-3.html" data-type="entity-link" >Route</a>
                            </li>
                            <li class="link">
                                <a href="classes/Settings.html" data-type="entity-link" >Settings</a>
                            </li>
                            <li class="link">
                                <a href="classes/Tela.html" data-type="entity-link" >Tela</a>
                            </li>
                        </ul>
                    </li>
                        <li class="chapter">
                            <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ? 'data-target="#injectables-links"' :
                                'data-target="#xs-injectables-links"' }>
                                <span class="icon ion-md-arrow-round-down"></span>
                                <span>Injectables</span>
                                <span class="icon ion-ios-arrow-down"></span>
                            </div>
                            <ul class="links collapse " ${ isNormalMode ? 'id="injectables-links"' : 'id="xs-injectables-links"' }>
                                <li class="link">
                                    <a href="injectables/ADVGFRPVService.html" data-type="entity-link" >ADVGFRPVService</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/AlertsService.html" data-type="entity-link" >AlertsService</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/AuthenticationService.html" data-type="entity-link" >AuthenticationService</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/CompanyService.html" data-type="entity-link" >CompanyService</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/DirectoryService.html" data-type="entity-link" >DirectoryService</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/GlobalMenuService.html" data-type="entity-link" >GlobalMenuService</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/GlobalTitle.html" data-type="entity-link" >GlobalTitle</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/GlobalWatcher.html" data-type="entity-link" >GlobalWatcher</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/ParameterService.html" data-type="entity-link" >ParameterService</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/PerfilService.html" data-type="entity-link" >PerfilService</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/ScreensService.html" data-type="entity-link" >ScreensService</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/StockService.html" data-type="entity-link" >StockService</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/TelasService.html" data-type="entity-link" >TelasService</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/UserGlobal.html" data-type="entity-link" >UserGlobal</a>
                                </li>
                                <li class="link">
                                    <a href="injectables/UserService.html" data-type="entity-link" >UserService</a>
                                </li>
                            </ul>
                        </li>
                    <li class="chapter">
                        <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ? 'data-target="#interfaces-links"' :
                            'data-target="#xs-interfaces-links"' }>
                            <span class="icon ion-md-information-circle-outline"></span>
                            <span>Interfaces</span>
                            <span class="icon ion-ios-arrow-down"></span>
                        </div>
                        <ul class="links collapse " ${ isNormalMode ? ' id="interfaces-links"' : 'id="xs-interfaces-links"' }>
                            <li class="link">
                                <a href="interfaces/IAD_ESTCODPROD.html" data-type="entity-link" >IAD_ESTCODPROD</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/IadDevsolicitacao.html" data-type="entity-link" >IadDevsolicitacao</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/IAvgfrpvgetall.html" data-type="entity-link" >IAvgfrpvgetall</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/IDiretorio.html" data-type="entity-link" >IDiretorio</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/IEmpresa.html" data-type="entity-link" >IEmpresa</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/ILoginValidation.html" data-type="entity-link" >ILoginValidation</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/INotaFinanceiro.html" data-type="entity-link" >INotaFinanceiro</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/INotaFiscal.html" data-type="entity-link" >INotaFiscal</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/IParametro.html" data-type="entity-link" >IParametro</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/IPedidoItem.html" data-type="entity-link" >IPedidoItem</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/IPerfil.html" data-type="entity-link" >IPerfil</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/IPerfilTela.html" data-type="entity-link" >IPerfilTela</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/IResponse.html" data-type="entity-link" >IResponse</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/IRoutes.html" data-type="entity-link" >IRoutes</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/ISolicitacaoDevolucao.html" data-type="entity-link" >ISolicitacaoDevolucao</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/ITcsprj.html" data-type="entity-link" >ITcsprj</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/ITela.html" data-type="entity-link" >ITela</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/ITGFcab.html" data-type="entity-link" >ITGFcab</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/ITGFGRU.html" data-type="entity-link" >ITGFGRU</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/ITgfpar.html" data-type="entity-link" >ITgfpar</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/ITGFRGV.html" data-type="entity-link" >ITGFRGV</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/ITgftpv.html" data-type="entity-link" >ITgftpv</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/IUser.html" data-type="entity-link" >IUser</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/IUsuario.html" data-type="entity-link" >IUsuario</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/IUsuarioEmp.html" data-type="entity-link" >IUsuarioEmp</a>
                            </li>
                            <li class="link">
                                <a href="interfaces/Pedido.html" data-type="entity-link" >Pedido</a>
                            </li>
                        </ul>
                    </li>
                    <li class="chapter">
                        <div class="simple menu-toggler" data-toggle="collapse" ${ isNormalMode ? 'data-target="#miscellaneous-links"'
                            : 'data-target="#xs-miscellaneous-links"' }>
                            <span class="icon ion-ios-cube"></span>
                            <span>Miscellaneous</span>
                            <span class="icon ion-ios-arrow-down"></span>
                        </div>
                        <ul class="links collapse " ${ isNormalMode ? 'id="miscellaneous-links"' : 'id="xs-miscellaneous-links"' }>
                            <li class="link">
                                <a href="miscellaneous/functions.html" data-type="entity-link">Functions</a>
                            </li>
                            <li class="link">
                                <a href="miscellaneous/variables.html" data-type="entity-link">Variables</a>
                            </li>
                        </ul>
                    </li>
                        <li class="chapter">
                            <a data-type="chapter-link" href="routes.html"><span class="icon ion-ios-git-branch"></span>Routes</a>
                        </li>
                    <li class="chapter">
                        <a data-type="chapter-link" href="coverage.html"><span class="icon ion-ios-stats"></span>Documentation coverage</a>
                    </li>
                    <li class="divider"></li>
                    <li class="copyright">
                        Documentation generated using <a href="https://compodoc.app/" target="_blank">
                            <img data-src="images/compodoc-vectorise.png" class="img-responsive" data-type="compodoc-logo">
                        </a>
                    </li>
            </ul>
        </nav>
        `);
        this.innerHTML = tp.strings;
    }
});