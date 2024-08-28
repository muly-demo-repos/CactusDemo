import { Injectable } from "@nestjs/common";
import { PrismaService } from "../prisma/prisma.service";
import { AbcServiceBase } from "./base/abc.service.base";

@Injectable()
export class AbcService extends AbcServiceBase {
  constructor(protected readonly prisma: PrismaService) {
    super(prisma);
  }
}
