import { Selecao } from "./selecao.model";

export interface Jogo {
  selecaoA: Selecao;
  selecaoB: Selecao;
  palpiteA: number;
  palpiteB: number;
  criadoEm?: string;
}
