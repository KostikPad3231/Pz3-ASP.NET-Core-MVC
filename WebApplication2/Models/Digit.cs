﻿// using Microsoft.ML.Data;
// using WebApplication1;
//
// namespace WebApplication2.Models;
//
// //Load sample data
// var sampleData = new MLModel1.ModelInput()
// {
//     Pixel0 = 0F,
//     Pixel1 = 0F,
//     Pixel2 = 0F,
//     Pixel3 = 0F,
//     Pixel4 = 0F,
//     Pixel5 = 0F,
//     Pixel6 = 0F,
//     Pixel7 = 0F,
//     Pixel8 = 0F,
//     Pixel9 = 0F,
//     Pixel10 = 0F,
//     Pixel11 = 0F,
//     Pixel12 = 0F,
//     Pixel13 = 0F,
//     Pixel14 = 0F,
//     Pixel15 = 0F,
//     Pixel16 = 0F,
//     Pixel17 = 0F,
//     Pixel18 = 0F,
//     Pixel19 = 0F,
//     Pixel20 = 0F,
//     Pixel21 = 0F,
//     Pixel22 = 0F,
//     Pixel23 = 0F,
//     Pixel24 = 0F,
//     Pixel25 = 0F,
//     Pixel26 = 0F,
//     Pixel27 = 0F,
//     Pixel28 = 0F,
//     Pixel29 = 0F,
//     Pixel30 = 0F,
//     Pixel31 = 0F,
//     Pixel32 = 0F,
//     Pixel33 = 0F,
//     Pixel34 = 0F,
//     Pixel35 = 0F,
//     Pixel36 = 0F,
//     Pixel37 = 0F,
//     Pixel38 = 0F,
//     Pixel39 = 0F,
//     Pixel40 = 0F,
//     Pixel41 = 0F,
//     Pixel42 = 0F,
//     Pixel43 = 0F,
//     Pixel44 = 0F,
//     Pixel45 = 0F,
//     Pixel46 = 0F,
//     Pixel47 = 0F,
//     Pixel48 = 0F,
//     Pixel49 = 0F,
//     Pixel50 = 0F,
//     Pixel51 = 0F,
//     Pixel52 = 0F,
//     Pixel53 = 0F,
//     Pixel54 = 0F,
//     Pixel55 = 0F,
//     Pixel56 = 0F,
//     Pixel57 = 0F,
//     Pixel58 = 0F,
//     Pixel59 = 0F,
//     Pixel60 = 0F,
//     Pixel61 = 0F,
//     Pixel62 = 0F,
//     Pixel63 = 0F,
//     Pixel64 = 0F,
//     Pixel65 = 0F,
//     Pixel66 = 0F,
//     Pixel67 = 0F,
//     Pixel68 = 0F,
//     Pixel69 = 0F,
//     Pixel70 = 0F,
//     Pixel71 = 0F,
//     Pixel72 = 0F,
//     Pixel73 = 0F,
//     Pixel74 = 0F,
//     Pixel75 = 0F,
//     Pixel76 = 0F,
//     Pixel77 = 0F,
//     Pixel78 = 0F,
//     Pixel79 = 0F,
//     Pixel80 = 0F,
//     Pixel81 = 0F,
//     Pixel82 = 0F,
//     Pixel83 = 0F,
//     Pixel84 = 0F,
//     Pixel85 = 0F,
//     Pixel86 = 0F,
//     Pixel87 = 0F,
//     Pixel88 = 0F,
//     Pixel89 = 0F,
//     Pixel90 = 0F,
//     Pixel91 = 0F,
//     Pixel92 = 0F,
//     Pixel93 = 0F,
//     Pixel94 = 0F,
//     Pixel95 = 0F,
//     Pixel96 = 0F,
//     Pixel97 = 0F,
//     Pixel98 = 0F,
//     Pixel99 = 0F,
//     Pixel100 = 0F,
//     Pixel101 = 0F,
//     Pixel102 = 0F,
//     Pixel103 = 0F,
//     Pixel104 = 0F,
//     Pixel105 = 0F,
//     Pixel106 = 0F,
//     Pixel107 = 0F,
//     Pixel108 = 0F,
//     Pixel109 = 0F,
//     Pixel110 = 0F,
//     Pixel111 = 0F,
//     Pixel112 = 0F,
//     Pixel113 = 0F,
//     Pixel114 = 0F,
//     Pixel115 = 0F,
//     Pixel116 = 0F,
//     Pixel117 = 0F,
//     Pixel118 = 0F,
//     Pixel119 = 0F,
//     Pixel120 = 0F,
//     Pixel121 = 0F,
//     Pixel122 = 18F,
//     Pixel123 = 30F,
//     Pixel124 = 137F,
//     Pixel125 = 137F,
//     Pixel126 = 192F,
//     Pixel127 = 86F,
//     Pixel128 = 72F,
//     Pixel129 = 1F,
//     Pixel130 = 0F,
//     Pixel131 = 0F,
//     Pixel132 = 0F,
//     Pixel133 = 0F,
//     Pixel134 = 0F,
//     Pixel135 = 0F,
//     Pixel136 = 0F,
//     Pixel137 = 0F,
//     Pixel138 = 0F,
//     Pixel139 = 0F,
//     Pixel140 = 0F,
//     Pixel141 = 0F,
//     Pixel142 = 0F,
//     Pixel143 = 0F,
//     Pixel144 = 0F,
//     Pixel145 = 0F,
//     Pixel146 = 0F,
//     Pixel147 = 0F,
//     Pixel148 = 13F,
//     Pixel149 = 86F,
//     Pixel150 = 250F,
//     Pixel151 = 254F,
//     Pixel152 = 254F,
//     Pixel153 = 254F,
//     Pixel154 = 254F,
//     Pixel155 = 217F,
//     Pixel156 = 246F,
//     Pixel157 = 151F,
//     Pixel158 = 32F,
//     Pixel159 = 0F,
//     Pixel160 = 0F,
//     Pixel161 = 0F,
//     Pixel162 = 0F,
//     Pixel163 = 0F,
//     Pixel164 = 0F,
//     Pixel165 = 0F,
//     Pixel166 = 0F,
//     Pixel167 = 0F,
//     Pixel168 = 0F,
//     Pixel169 = 0F,
//     Pixel170 = 0F,
//     Pixel171 = 0F,
//     Pixel172 = 0F,
//     Pixel173 = 0F,
//     Pixel174 = 0F,
//     Pixel175 = 16F,
//     Pixel176 = 179F,
//     Pixel177 = 254F,
//     Pixel178 = 254F,
//     Pixel179 = 254F,
//     Pixel180 = 254F,
//     Pixel181 = 254F,
//     Pixel182 = 254F,
//     Pixel183 = 254F,
//     Pixel184 = 254F,
//     Pixel185 = 254F,
//     Pixel186 = 231F,
//     Pixel187 = 54F,
//     Pixel188 = 15F,
//     Pixel189 = 0F,
//     Pixel190 = 0F,
//     Pixel191 = 0F,
//     Pixel192 = 0F,
//     Pixel193 = 0F,
//     Pixel194 = 0F,
//     Pixel195 = 0F,
//     Pixel196 = 0F,
//     Pixel197 = 0F,
//     Pixel198 = 0F,
//     Pixel199 = 0F,
//     Pixel200 = 0F,
//     Pixel201 = 0F,
//     Pixel202 = 0F,
//     Pixel203 = 72F,
//     Pixel204 = 254F,
//     Pixel205 = 254F,
//     Pixel206 = 254F,
//     Pixel207 = 254F,
//     Pixel208 = 254F,
//     Pixel209 = 254F,
//     Pixel210 = 254F,
//     Pixel211 = 254F,
//     Pixel212 = 254F,
//     Pixel213 = 254F,
//     Pixel214 = 254F,
//     Pixel215 = 254F,
//     Pixel216 = 104F,
//     Pixel217 = 0F,
//     Pixel218 = 0F,
//     Pixel219 = 0F,
//     Pixel220 = 0F,
//     Pixel221 = 0F,
//     Pixel222 = 0F,
//     Pixel223 = 0F,
//     Pixel224 = 0F,
//     Pixel225 = 0F,
//     Pixel226 = 0F,
//     Pixel227 = 0F,
//     Pixel228 = 0F,
//     Pixel229 = 0F,
//     Pixel230 = 61F,
//     Pixel231 = 191F,
//     Pixel232 = 254F,
//     Pixel233 = 254F,
//     Pixel234 = 254F,
//     Pixel235 = 254F,
//     Pixel236 = 254F,
//     Pixel237 = 109F,
//     Pixel238 = 83F,
//     Pixel239 = 199F,
//     Pixel240 = 254F,
//     Pixel241 = 254F,
//     Pixel242 = 254F,
//     Pixel243 = 254F,
//     Pixel244 = 243F,
//     Pixel245 = 85F,
//     Pixel246 = 0F,
//     Pixel247 = 0F,
//     Pixel248 = 0F,
//     Pixel249 = 0F,
//     Pixel250 = 0F,
//     Pixel251 = 0F,
//     Pixel252 = 0F,
//     Pixel253 = 0F,
//     Pixel254 = 0F,
//     Pixel255 = 0F,
//     Pixel256 = 0F,
//     Pixel257 = 0F,
//     Pixel258 = 172F,
//     Pixel259 = 254F,
//     Pixel260 = 254F,
//     Pixel261 = 254F,
//     Pixel262 = 202F,
//     Pixel263 = 147F,
//     Pixel264 = 147F,
//     Pixel265 = 45F,
//     Pixel266 = 0F,
//     Pixel267 = 11F,
//     Pixel268 = 29F,
//     Pixel269 = 200F,
//     Pixel270 = 254F,
//     Pixel271 = 254F,
//     Pixel272 = 254F,
//     Pixel273 = 171F,
//     Pixel274 = 0F,
//     Pixel275 = 0F,
//     Pixel276 = 0F,
//     Pixel277 = 0F,
//     Pixel278 = 0F,
//     Pixel279 = 0F,
//     Pixel280 = 0F,
//     Pixel281 = 0F,
//     Pixel282 = 0F,
//     Pixel283 = 0F,
//     Pixel284 = 0F,
//     Pixel285 = 1F,
//     Pixel286 = 174F,
//     Pixel287 = 254F,
//     Pixel288 = 254F,
//     Pixel289 = 89F,
//     Pixel290 = 67F,
//     Pixel291 = 0F,
//     Pixel292 = 0F,
//     Pixel293 = 0F,
//     Pixel294 = 0F,
//     Pixel295 = 0F,
//     Pixel296 = 0F,
//     Pixel297 = 128F,
//     Pixel298 = 252F,
//     Pixel299 = 254F,
//     Pixel300 = 254F,
//     Pixel301 = 212F,
//     Pixel302 = 76F,
//     Pixel303 = 0F,
//     Pixel304 = 0F,
//     Pixel305 = 0F,
//     Pixel306 = 0F,
//     Pixel307 = 0F,
//     Pixel308 = 0F,
//     Pixel309 = 0F,
//     Pixel310 = 0F,
//     Pixel311 = 0F,
//     Pixel312 = 0F,
//     Pixel313 = 47F,
//     Pixel314 = 254F,
//     Pixel315 = 254F,
//     Pixel316 = 254F,
//     Pixel317 = 29F,
//     Pixel318 = 0F,
//     Pixel319 = 0F,
//     Pixel320 = 0F,
//     Pixel321 = 0F,
//     Pixel322 = 0F,
//     Pixel323 = 0F,
//     Pixel324 = 0F,
//     Pixel325 = 0F,
//     Pixel326 = 83F,
//     Pixel327 = 254F,
//     Pixel328 = 254F,
//     Pixel329 = 254F,
//     Pixel330 = 153F,
//     Pixel331 = 0F,
//     Pixel332 = 0F,
//     Pixel333 = 0F,
//     Pixel334 = 0F,
//     Pixel335 = 0F,
//     Pixel336 = 0F,
//     Pixel337 = 0F,
//     Pixel338 = 0F,
//     Pixel339 = 0F,
//     Pixel340 = 0F,
//     Pixel341 = 80F,
//     Pixel342 = 254F,
//     Pixel343 = 254F,
//     Pixel344 = 240F,
//     Pixel345 = 24F,
//     Pixel346 = 0F,
//     Pixel347 = 0F,
//     Pixel348 = 0F,
//     Pixel349 = 0F,
//     Pixel350 = 0F,
//     Pixel351 = 0F,
//     Pixel352 = 0F,
//     Pixel353 = 0F,
//     Pixel354 = 25F,
//     Pixel355 = 240F,
//     Pixel356 = 254F,
//     Pixel357 = 254F,
//     Pixel358 = 153F,
//     Pixel359 = 0F,
//     Pixel360 = 0F,
//     Pixel361 = 0F,
//     Pixel362 = 0F,
//     Pixel363 = 0F,
//     Pixel364 = 0F,
//     Pixel365 = 0F,
//     Pixel366 = 0F,
//     Pixel367 = 0F,
//     Pixel368 = 0F,
//     Pixel369 = 64F,
//     Pixel370 = 254F,
//     Pixel371 = 254F,
//     Pixel372 = 186F,
//     Pixel373 = 7F,
//     Pixel374 = 0F,
//     Pixel375 = 0F,
//     Pixel376 = 0F,
//     Pixel377 = 0F,
//     Pixel378 = 0F,
//     Pixel379 = 0F,
//     Pixel380 = 0F,
//     Pixel381 = 0F,
//     Pixel382 = 0F,
//     Pixel383 = 166F,
//     Pixel384 = 254F,
//     Pixel385 = 254F,
//     Pixel386 = 224F,
//     Pixel387 = 12F,
//     Pixel388 = 0F,
//     Pixel389 = 0F,
//     Pixel390 = 0F,
//     Pixel391 = 0F,
//     Pixel392 = 0F,
//     Pixel393 = 0F,
//     Pixel394 = 0F,
//     Pixel395 = 0F,
//     Pixel396 = 14F,
//     Pixel397 = 232F,
//     Pixel398 = 254F,
//     Pixel399 = 254F,
//     Pixel400 = 254F,
//     Pixel401 = 29F,
//     Pixel402 = 0F,
//     Pixel403 = 0F,
//     Pixel404 = 0F,
//     Pixel405 = 0F,
//     Pixel406 = 0F,
//     Pixel407 = 0F,
//     Pixel408 = 0F,
//     Pixel409 = 0F,
//     Pixel410 = 0F,
//     Pixel411 = 75F,
//     Pixel412 = 254F,
//     Pixel413 = 254F,
//     Pixel414 = 254F,
//     Pixel415 = 17F,
//     Pixel416 = 0F,
//     Pixel417 = 0F,
//     Pixel418 = 0F,
//     Pixel419 = 0F,
//     Pixel420 = 0F,
//     Pixel421 = 0F,
//     Pixel422 = 0F,
//     Pixel423 = 0F,
//     Pixel424 = 18F,
//     Pixel425 = 254F,
//     Pixel426 = 254F,
//     Pixel427 = 254F,
//     Pixel428 = 254F,
//     Pixel429 = 29F,
//     Pixel430 = 0F,
//     Pixel431 = 0F,
//     Pixel432 = 0F,
//     Pixel433 = 0F,
//     Pixel434 = 0F,
//     Pixel435 = 0F,
//     Pixel436 = 0F,
//     Pixel437 = 0F,
//     Pixel438 = 0F,
//     Pixel439 = 48F,
//     Pixel440 = 254F,
//     Pixel441 = 254F,
//     Pixel442 = 254F,
//     Pixel443 = 17F,
//     Pixel444 = 0F,
//     Pixel445 = 0F,
//     Pixel446 = 0F,
//     Pixel447 = 0F,
//     Pixel448 = 0F,
//     Pixel449 = 0F,
//     Pixel450 = 0F,
//     Pixel451 = 0F,
//     Pixel452 = 2F,
//     Pixel453 = 163F,
//     Pixel454 = 254F,
//     Pixel455 = 254F,
//     Pixel456 = 254F,
//     Pixel457 = 29F,
//     Pixel458 = 0F,
//     Pixel459 = 0F,
//     Pixel460 = 0F,
//     Pixel461 = 0F,
//     Pixel462 = 0F,
//     Pixel463 = 0F,
//     Pixel464 = 0F,
//     Pixel465 = 0F,
//     Pixel466 = 0F,
//     Pixel467 = 48F,
//     Pixel468 = 254F,
//     Pixel469 = 254F,
//     Pixel470 = 254F,
//     Pixel471 = 17F,
//     Pixel472 = 0F,
//     Pixel473 = 0F,
//     Pixel474 = 0F,
//     Pixel475 = 0F,
//     Pixel476 = 0F,
//     Pixel477 = 0F,
//     Pixel478 = 0F,
//     Pixel479 = 0F,
//     Pixel480 = 0F,
//     Pixel481 = 94F,
//     Pixel482 = 254F,
//     Pixel483 = 254F,
//     Pixel484 = 254F,
//     Pixel485 = 200F,
//     Pixel486 = 12F,
//     Pixel487 = 0F,
//     Pixel488 = 0F,
//     Pixel489 = 0F,
//     Pixel490 = 0F,
//     Pixel491 = 0F,
//     Pixel492 = 0F,
//     Pixel493 = 0F,
//     Pixel494 = 16F,
//     Pixel495 = 209F,
//     Pixel496 = 254F,
//     Pixel497 = 254F,
//     Pixel498 = 150F,
//     Pixel499 = 1F,
//     Pixel500 = 0F,
//     Pixel501 = 0F,
//     Pixel502 = 0F,
//     Pixel503 = 0F,
//     Pixel504 = 0F,
//     Pixel505 = 0F,
//     Pixel506 = 0F,
//     Pixel507 = 0F,
//     Pixel508 = 0F,
//     Pixel509 = 15F,
//     Pixel510 = 206F,
//     Pixel511 = 254F,
//     Pixel512 = 254F,
//     Pixel513 = 254F,
//     Pixel514 = 202F,
//     Pixel515 = 66F,
//     Pixel516 = 0F,
//     Pixel517 = 0F,
//     Pixel518 = 0F,
//     Pixel519 = 0F,
//     Pixel520 = 0F,
//     Pixel521 = 21F,
//     Pixel522 = 161F,
//     Pixel523 = 254F,
//     Pixel524 = 254F,
//     Pixel525 = 245F,
//     Pixel526 = 31F,
//     Pixel527 = 0F,
//     Pixel528 = 0F,
//     Pixel529 = 0F,
//     Pixel530 = 0F,
//     Pixel531 = 0F,
//     Pixel532 = 0F,
//     Pixel533 = 0F,
//     Pixel534 = 0F,
//     Pixel535 = 0F,
//     Pixel536 = 0F,
//     Pixel537 = 0F,
//     Pixel538 = 60F,
//     Pixel539 = 212F,
//     Pixel540 = 254F,
//     Pixel541 = 254F,
//     Pixel542 = 254F,
//     Pixel543 = 194F,
//     Pixel544 = 48F,
//     Pixel545 = 48F,
//     Pixel546 = 34F,
//     Pixel547 = 41F,
//     Pixel548 = 48F,
//     Pixel549 = 209F,
//     Pixel550 = 254F,
//     Pixel551 = 254F,
//     Pixel552 = 254F,
//     Pixel553 = 171F,
//     Pixel554 = 0F,
//     Pixel555 = 0F,
//     Pixel556 = 0F,
//     Pixel557 = 0F,
//     Pixel558 = 0F,
//     Pixel559 = 0F,
//     Pixel560 = 0F,
//     Pixel561 = 0F,
//     Pixel562 = 0F,
//     Pixel563 = 0F,
//     Pixel564 = 0F,
//     Pixel565 = 0F,
//     Pixel566 = 0F,
//     Pixel567 = 86F,
//     Pixel568 = 243F,
//     Pixel569 = 254F,
//     Pixel570 = 254F,
//     Pixel571 = 254F,
//     Pixel572 = 254F,
//     Pixel573 = 254F,
//     Pixel574 = 233F,
//     Pixel575 = 243F,
//     Pixel576 = 254F,
//     Pixel577 = 254F,
//     Pixel578 = 254F,
//     Pixel579 = 254F,
//     Pixel580 = 254F,
//     Pixel581 = 86F,
//     Pixel582 = 0F,
//     Pixel583 = 0F,
//     Pixel584 = 0F,
//     Pixel585 = 0F,
//     Pixel586 = 0F,
//     Pixel587 = 0F,
//     Pixel588 = 0F,
//     Pixel589 = 0F,
//     Pixel590 = 0F,
//     Pixel591 = 0F,
//     Pixel592 = 0F,
//     Pixel593 = 0F,
//     Pixel594 = 0F,
//     Pixel595 = 0F,
//     Pixel596 = 114F,
//     Pixel597 = 254F,
//     Pixel598 = 254F,
//     Pixel599 = 254F,
//     Pixel600 = 254F,
//     Pixel601 = 254F,
//     Pixel602 = 254F,
//     Pixel603 = 254F,
//     Pixel604 = 254F,
//     Pixel605 = 254F,
//     Pixel606 = 254F,
//     Pixel607 = 239F,
//     Pixel608 = 86F,
//     Pixel609 = 11F,
//     Pixel610 = 0F,
//     Pixel611 = 0F,
//     Pixel612 = 0F,
//     Pixel613 = 0F,
//     Pixel614 = 0F,
//     Pixel615 = 0F,
//     Pixel616 = 0F,
//     Pixel617 = 0F,
//     Pixel618 = 0F,
//     Pixel619 = 0F,
//     Pixel620 = 0F,
//     Pixel621 = 0F,
//     Pixel622 = 0F,
//     Pixel623 = 0F,
//     Pixel624 = 13F,
//     Pixel625 = 182F,
//     Pixel626 = 254F,
//     Pixel627 = 254F,
//     Pixel628 = 254F,
//     Pixel629 = 254F,
//     Pixel630 = 254F,
//     Pixel631 = 254F,
//     Pixel632 = 254F,
//     Pixel633 = 254F,
//     Pixel634 = 243F,
//     Pixel635 = 70F,
//     Pixel636 = 0F,
//     Pixel637 = 0F,
//     Pixel638 = 0F,
//     Pixel639 = 0F,
//     Pixel640 = 0F,
//     Pixel641 = 0F,
//     Pixel642 = 0F,
//     Pixel643 = 0F,
//     Pixel644 = 0F,
//     Pixel645 = 0F,
//     Pixel646 = 0F,
//     Pixel647 = 0F,
//     Pixel648 = 0F,
//     Pixel649 = 0F,
//     Pixel650 = 0F,
//     Pixel651 = 0F,
//     Pixel652 = 0F,
//     Pixel653 = 8F,
//     Pixel654 = 76F,
//     Pixel655 = 146F,
//     Pixel656 = 254F,
//     Pixel657 = 255F,
//     Pixel658 = 254F,
//     Pixel659 = 255F,
//     Pixel660 = 146F,
//     Pixel661 = 19F,
//     Pixel662 = 15F,
//     Pixel663 = 0F,
//     Pixel664 = 0F,
//     Pixel665 = 0F,
//     Pixel666 = 0F,
//     Pixel667 = 0F,
//     Pixel668 = 0F,
//     Pixel669 = 0F,
//     Pixel670 = 0F,
//     Pixel671 = 0F,
//     Pixel672 = 0F,
//     Pixel673 = 0F,
//     Pixel674 = 0F,
//     Pixel675 = 0F,
//     Pixel676 = 0F,
//     Pixel677 = 0F,
//     Pixel678 = 0F,
//     Pixel679 = 0F,
//     Pixel680 = 0F,
//     Pixel681 = 0F,
//     Pixel682 = 0F,
//     Pixel683 = 0F,
//     Pixel684 = 0F,
//     Pixel685 = 0F,
//     Pixel686 = 0F,
//     Pixel687 = 0F,
//     Pixel688 = 0F,
//     Pixel689 = 0F,
//     Pixel690 = 0F,
//     Pixel691 = 0F,
//     Pixel692 = 0F,
//     Pixel693 = 0F,
//     Pixel694 = 0F,
//     Pixel695 = 0F,
//     Pixel696 = 0F,
//     Pixel697 = 0F,
//     Pixel698 = 0F,
//     Pixel699 = 0F,
//     Pixel700 = 0F,
//     Pixel701 = 0F,
//     Pixel702 = 0F,
//     Pixel703 = 0F,
//     Pixel704 = 0F,
//     Pixel705 = 0F,
//     Pixel706 = 0F,
//     Pixel707 = 0F,
//     Pixel708 = 0F,
//     Pixel709 = 0F,
//     Pixel710 = 0F,
//     Pixel711 = 0F,
//     Pixel712 = 0F,
//     Pixel713 = 0F,
//     Pixel714 = 0F,
//     Pixel715 = 0F,
//     Pixel716 = 0F,
//     Pixel717 = 0F,
//     Pixel718 = 0F,
//     Pixel719 = 0F,
//     Pixel720 = 0F,
//     Pixel721 = 0F,
//     Pixel722 = 0F,
//     Pixel723 = 0F,
//     Pixel724 = 0F,
//     Pixel725 = 0F,
//     Pixel726 = 0F,
//     Pixel727 = 0F,
//     Pixel728 = 0F,
//     Pixel729 = 0F,
//     Pixel730 = 0F,
//     Pixel731 = 0F,
//     Pixel732 = 0F,
//     Pixel733 = 0F,
//     Pixel734 = 0F,
//     Pixel735 = 0F,
//     Pixel736 = 0F,
//     Pixel737 = 0F,
//     Pixel738 = 0F,
//     Pixel739 = 0F,
//     Pixel740 = 0F,
//     Pixel741 = 0F,
//     Pixel742 = 0F,
//     Pixel743 = 0F,
//     Pixel744 = 0F,
//     Pixel745 = 0F,
//     Pixel746 = 0F,
//     Pixel747 = 0F,
//     Pixel748 = 0F,
//     Pixel749 = 0F,
//     Pixel750 = 0F,
//     Pixel751 = 0F,
//     Pixel752 = 0F,
//     Pixel753 = 0F,
//     Pixel754 = 0F,
//     Pixel755 = 0F,
//     Pixel756 = 0F,
//     Pixel757 = 0F,
//     Pixel758 = 0F,
//     Pixel759 = 0F,
//     Pixel760 = 0F,
//     Pixel761 = 0F,
//     Pixel762 = 0F,
//     Pixel763 = 0F,
//     Pixel764 = 0F,
//     Pixel765 = 0F,
//     Pixel766 = 0F,
//     Pixel767 = 0F,
//     Pixel768 = 0F,
//     Pixel769 = 0F,
//     Pixel770 = 0F,
//     Pixel771 = 0F,
//     Pixel772 = 0F,
//     Pixel773 = 0F,
//     Pixel774 = 0F,
//     Pixel775 = 0F,
//     Pixel776 = 0F,
//     Pixel777 = 0F,
//     Pixel778 = 0F,
//     Pixel779 = 0F,
//     Pixel780 = 0F,
//     Pixel781 = 0F,
//     Pixel782 = 0F,
//     Pixel783 = 0F,
// };
//
// //Load model and predict output
// var result = MLModel1.Predict(sampleData);
