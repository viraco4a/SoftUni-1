<?php

// This file has been auto-generated by the Symfony Dependency Injection Component for internal use.

if (\class_exists(\ContainerYh3wpgm\appDevDebugProjectContainer::class, false)) {
    // no-op
} elseif (!include __DIR__.'/ContainerYh3wpgm/appDevDebugProjectContainer.php') {
    touch(__DIR__.'/ContainerYh3wpgm.legacy');

    return;
}

if (!\class_exists(appDevDebugProjectContainer::class, false)) {
    \class_alias(\ContainerYh3wpgm\appDevDebugProjectContainer::class, appDevDebugProjectContainer::class, false);
}

return new \ContainerYh3wpgm\appDevDebugProjectContainer(array(
    'container.build_hash' => 'Yh3wpgm',
    'container.build_id' => 'fa0d6f37',
    'container.build_time' => 1534055114,
), __DIR__.\DIRECTORY_SEPARATOR.'ContainerYh3wpgm');
